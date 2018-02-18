using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// New References
using AForge.Neuro;
using AForge.Neuro.Learning;
using AForge.Imaging.Filters;

using System.Drawing.Imaging;
using System.IO;

namespace FulgurantArt
{
    public partial class CheckCategoryForm : Form
    {
        BackPropagationLearning backpropagationLearning;

        static int width = 10, height = 10;

        List<double[]> listOfInput;

        List<int> listOfOutput;

        List<String> listImageNames;
        List<String> listFiles;

        String picturesPath;
        String pathDirectory;
        String outputImage;
        String loadedImage;

        public CheckCategoryForm(Boolean checkListAllImages, List<String> listAllImages)
        {
            InitializeComponent();

            picturesPath = Application.StartupPath + @"\pictures";

            pathDirectory = "";
            outputImage = "";
            loadedImage = "";

            Network.checkAddArt = checkListAllImages;

            listOfInput = new List<double[]>();

            listOfOutput = new List<int>();

            listImageNames = new List<String>();
            listFiles = new List<String>();

            listFiles = listAllImages;

            // If there is no image in the list, then show warning message and go back to Main Form.
            if (listFiles.Count <= 0)
            {
                MessageBox.Show("Add some art first!");

                // Show Main Form
                MainForm mainForm = new MainForm();
                mainForm.Show();

                // Close Check Category Form
                this.Close();
            }

            // Otherwise, then train all images in the list.
            else
            {
                // BPNNBrain.net doesn't exist && user doesn't add some art
                if (Network.loadActivationNetwork == null && !Network.checkAddArt)
                {
                    Network.activationNetwork = new ActivationNetwork(new SigmoidFunction(), width * height, 4, 1);

                    backpropagationLearning = new BackPropagationLearning(Network.activationNetwork);
                }
                // BPNNBrain.net does exist && user add some art
                else if (Network.loadActivationNetwork != null && Network.checkAddArt)
                {
                    Network.activationNetwork = new ActivationNetwork(new SigmoidFunction(), width * height, 4, 1);

                    backpropagationLearning = new BackPropagationLearning(Network.activationNetwork);
                }
                else if (Network.loadActivationNetwork == null)
                {
                    Network.activationNetwork = new ActivationNetwork(new SigmoidFunction(), width * height, 4, 1);

                    backpropagationLearning = new BackPropagationLearning(Network.activationNetwork);
                }
                else if (Network.loadActivationNetwork != null)
                {
                    Network.activationNetwork = Network.loadActivationNetwork;
                }

                // Train All Images
                foreach (var item in listFiles)
                {
                    ImagesTraining(new Bitmap(item), item);
                }
            }
        }

        // If user clicks Back Link Label, then go back to Main Form.
        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide Browse Form
            this.Hide();

            // Show Main Form
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnCheckCategoryOrBrowseArt_Click(object sender, EventArgs e)
        {
            if (btnCheckCategoryOrBrowseArt.Text == "Browse Art")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Validate image extension must be either “jpg”, “jpeg”, or “png”.
                openFileDialog.Filter = "Image Files | *.jpg; *jpeg; *.png";

                if (Directory.Exists(picturesPath))
                {
                    openFileDialog.InitialDirectory = picturesPath;
                }
                else
                {
                    openFileDialog.InitialDirectory = "";
                }

                // If user confirms to open image, then show selected image to Category Picture Box and change Category Button text to “Check Category”.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFileDialog.FileName;
                    pbArt.ImageLocation = fileName;
                    loadedImage = fileName;
                    btnCheckCategoryOrBrowseArt.Text = "Check Category";
                    lblTitle.Visible = false;
                    lblCategory.Visible = false;
                }
            }
            else if (btnCheckCategoryOrBrowseArt.Text == "Check Category")
            {
                // Image Preprocessing
                pbArt.Image = ImagePreprocessing(new Bitmap(loadedImage), 127);
               
                // Category Prediction
                String category = CategoryPrediction();

                MessageBox.Show("Predicting Category Success!");

                lblTitle.Visible = true;
                lblCategory.Visible = true;
                lblCategory.Text = category;
            }
        }

        // Image Preprocessing
        private Bitmap ImagePreprocessing(Bitmap image, int threshold)
        {
            // Grayscale
            image = Grayscale.CommonAlgorithms.RMY.Apply(image);

            // Edge Detection (using CannyEdgeDetector)
            image = new CannyEdgeDetector().Apply(image);

            // Noise Removal
            int startX, startY, endX, endY;

            startX = image.Width;
            startY = image.Height;
            endX = 0;
            endY = 0;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (image.GetPixel(i, j).R > threshold)
                    {
                        if (i < startX) startX = i;
                        if (j < startY) startY = j;
                        if (i > endX) endX = i;
                        if (j > endY) endY = j;
                    }
                }
            }

            image = image.Clone(new Rectangle(startX, startY, endX - startX, endY - startY), PixelFormat.Format8bppIndexed);

            // Resize
            image = new ResizeBilinear(32, 32).Apply(image);

            return image;
        }

        private double[] NormalizeInput(Bitmap image)
        {
            double[] normalizeImage = new double[width * height];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    normalizeImage[i * height + j] = (double)image.GetPixel(j, i).R / 255.0;
                }
            }

            return normalizeImage;
        }

        private double[][] NormalizeOutput()
        {
            List<double[]> normalizeOutput = new List<double[]>();

            foreach (var output in listOfOutput)
            {
                normalizeOutput.Add(new double[] { (double)output / listImageNames.Count });
            }

            return normalizeOutput.ToArray();
        }

        private void ImagesTraining(Bitmap image, String filePath)
        {
            int output;

            if (image == null)
            {
                listOfInput.Add(NormalizeInput((Bitmap)pbArt.Image));
            }
            else
            {
                image = ImagePreprocessing(image, 127);
                listOfInput.Add(NormalizeInput(image));
            }
            
            if (filePath == null)
            {
                pathDirectory = Path.GetDirectoryName(loadedImage);
                outputImage = Path.GetFileName(pathDirectory);
            }
            else
            {
                pathDirectory = Path.GetDirectoryName(filePath);
                outputImage = Path.GetFileName(pathDirectory);
            }
          
            if (listImageNames.Contains(outputImage))
            {
                output = listImageNames.IndexOf(outputImage);
            }
            else
            {
                listImageNames.Add(outputImage);

                output = listImageNames.Count() - 1;
            }

            listOfOutput.Add(output);

            if (backpropagationLearning != null)
            {
                // Training Process
                double maxEpochs = 10000, errorRate = 0.0000001;

                for (int i = 0; i < maxEpochs; i++)
                {
                    double result = backpropagationLearning.RunEpoch(listOfInput.ToArray(), NormalizeOutput());

                    if (result < errorRate)
                    {
                        break;
                    }
                }
            }
        }

        private String CategoryPrediction()
        {
            String categoryPrediction = "";

            double[] normalizeImage = NormalizeInput((Bitmap)pbArt.Image);

            if (listImageNames.Count != 0)
            {
                double[] index = Network.activationNetwork.Compute(normalizeImage);

                categoryPrediction = listImageNames[(int)(index[0] * listImageNames.Count)];
            }

            return categoryPrediction;
        }

        private void ClearForm()
        {
            btnCheckCategoryOrBrowseArt.Text = "Browse Art";
            lblTitle.Visible = true;
            lblCategory.Visible = true;
            lblCategory.Text = "";
            loadedImage = "";
            pbArt.Image = null;
            pbArt.ImageLocation = null;

            listOfInput = new List<double[]>();

            listOfOutput = new List<int>();

            listImageNames = new List<String>();
            listFiles = new List<String>();
        }
    }
}
