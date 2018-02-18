using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// New References
using AForge.Neuro;
using AForge.Neuro.Learning;
using AForge.Imaging.Filters;
using Accord.Imaging.Converters;
using Accord.Statistics.Analysis;

using System.Drawing.Imaging;
using System.IO;

namespace FulgurantArt
{
    public partial class ArtDetailForm : Form
    {
        List<Bitmap> listImages;

        List<String> listImageNames;
        List<String> listFiles;

        // Principal Component Analysis
        PrincipalComponentAnalysis principalComponentAnalysis;

        // Self-Organizing Map Learning
        SOMLearning somLearning;

        public ArtDetailForm(List<String> listAllImages, String picturesPath, String pictureName)
        {
            InitializeComponent();

            listImages = new List<Bitmap>();

            listFiles = new List<String>();
            listImageNames = new List<String>();

            // Show the selected image from Browse Form to Image Picture Box.
            pbArtDetail.ImageLocation = picturesPath;

            lblPictureName.Text = pictureName;

            listFiles = listAllImages;

            foreach (var item in listFiles)
            {
                listImages.Add(new Bitmap(item));
                listImageNames.Add(item);
            }

            // Show similar images of the selected image using Kohonen SOM method to the Similar Art List View.

            // 1. PCA Processing
            principalComponentAnalysisProcessing();

            // 2. SOM Processing
            somLearningProcessing();
            
            // 3. Show Similar Art
            showSimilarArt(picturesPath);
        }
       
        private void principalComponentAnalysisProcessing()
        {
            double[][] datas = new double[listImages.Count][];
            double[] data;

            ImageToArray imageConverter = new ImageToArray();

            for (int i = 0; i < listImages.Count; i++)
            {
                // Image Preprocessing
                Bitmap preprocessedImage = ImagePreprocessing(listImages[i], 127);

                // Convert to Double[]
                imageConverter.Convert(preprocessedImage, out data);

                // Input Dataset
                datas[i] = data;
            }

            // Compute PCA
            principalComponentAnalysis = new PrincipalComponentAnalysis(datas);
            principalComponentAnalysis.Compute();
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

        private void somLearningProcessing()
        {
            // PCA.GetLength(1) means that first dimension is column and zero dimension is row
            // neuronsCount must square root of 2
            // Find nearest square with total images

            int sqrt = (int)Math.Ceiling(Math.Sqrt(listImages.Count));

            if (sqrt <= 1)
            {
                sqrt = 2;
            }

            // SOMBrain.net doesn't exist && user doesn't add some art
            if (Network.loadDistanceNetwork == null && !Network.checkAddArt)
            {
                Network.distanceNetwork = new DistanceNetwork(principalComponentAnalysis.Result.GetLength(1), (int)Math.Pow(sqrt, 2));

                somLearning = new SOMLearning(Network.distanceNetwork);
            }
            // SOMBrain.net doest exist && user add some art
            else if (Network.loadDistanceNetwork != null && Network.checkAddArt)
            {
                Network.distanceNetwork = new DistanceNetwork(principalComponentAnalysis.Result.GetLength(1), (int)Math.Pow(sqrt, 2));

                somLearning = new SOMLearning(Network.distanceNetwork);
            }
            else if (Network.loadDistanceNetwork == null)
            {
                Network.distanceNetwork = new DistanceNetwork(principalComponentAnalysis.Result.GetLength(1), (int)Math.Pow(sqrt, 2));

                somLearning = new SOMLearning(Network.distanceNetwork);
            }
            else if (Network.loadActivationNetwork != null)
            {
                Network.distanceNetwork = Network.loadDistanceNetwork;
            }

            //change double [,] to double[][]
            double[][] data = new double[listImages.Count][];

            for (int i = 0; i < listImages.Count; i++)
            {
                data[i] = new double[principalComponentAnalysis.Result.GetLength(1)];

                for (int j = 0; j < principalComponentAnalysis.Result.GetLength(1); j++)
                {
                    data[i][j] = principalComponentAnalysis.Result[i, j];
                }
            }

            if (somLearning != null)
            {
                double maxEpochs = 10000, errorRate = 0.0000001;

                for (int i = 0; i < maxEpochs; i++)
                {
                    double error = somLearning.RunEpoch(data);

                    if (error < errorRate)
                    {
                        break;
                    }
                }
            }
        }

        private void showSimilarArt(String picturesPath)
        {
            pbArtDetail.Image = ImagePreprocessing(new Bitmap(picturesPath), 127);

            // Convert image to double
            ImageToArray imageConverter = new ImageToArray();
            double[] data;

            imageConverter.Convert(new Bitmap(pbArtDetail.Image), out data);

            // Convert to PCA
            data = principalComponentAnalysis.Transform(data);

            // Find the similar image
            Network.distanceNetwork.Compute(data);

            // Get nearest neuron
            int winner = Network.distanceNetwork.GetWinner();

            imageListSimilarArt.Images.Clear();
            listViewSimilarArt.Items.Clear();

            for (int i = 0; i < listImages.Count; i++)
            {
                double[] imageData = new double[principalComponentAnalysis.Result.GetLength(1)];

                for (int j = 0; j < principalComponentAnalysis.Result.GetLength(1); j++)
                {
                    imageData[j] = principalComponentAnalysis.Result[i, j];
                }

                Network.distanceNetwork.Compute(imageData);

                int imageWinner = Network.distanceNetwork.GetWinner();

                if (winner == imageWinner)
                {
                    if (listImageNames[i] != picturesPath)
                    {
                        listViewSimilarArt.Groups.Add("groupKey0", "Similar Art");

                        imageListSimilarArt.Images.Add(listImageNames[i], listImages[i]);

                        ListViewItem listViewItem = new ListViewItem(Path.GetFileName(listImageNames[i]), listImageNames[i], listViewSimilarArt.Groups[0]);
                        listViewSimilarArt.Items.Add(listViewItem);
                    }
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

        private void listViewSimilarArt_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewSimilarArt.SelectedItems)
            {
                pbArtDetail.ImageLocation = item.ImageKey;
                
                // Principal Component Analysis
                principalComponentAnalysisProcessing();

                // Self-Organizing Map Learning
                somLearningProcessing();

                // Show Similar Art
                showSimilarArt(item.ImageKey);
            }
        }
    }
}