using System;
using System.Collections.Generic;
using System.Windows.Forms;

// New References;
using System.IO;

using AForge.Neuro;

namespace FulgurantArt
{
    public partial class MainForm : Form
    {
        String picturesPath;

        List<String> listAllImages;

        // Check if the BPNNBrain.net or SOMBrain.net is already loaded and user add art, then we have to do training again
        Boolean checkListAllImages; 

        public MainForm()
        {
            InitializeComponent();

            picturesPath = Application.StartupPath + @"\pictures";

            listAllImages = new List<String>();

            // Check BPNNBrain.net file
            if (File.Exists("BPNNBrain.net"))
            {
                // Load BPNNBrain.net file
                Network.loadActivationNetwork = (ActivationNetwork)ActivationNetwork.Load("BPNNBrain.net");
            }

            // Check SOMBrain.net file
            if (File.Exists("SOMBrain.net"))
            {
                // Load SOMBrain.net file
                Network.loadDistanceNetwork = (DistanceNetwork)DistanceNetwork.Load("SOMBrain.net");
            }

            // Check pictures directory
            if (Directory.Exists(picturesPath))
            {
                // Load All Images
                listAllImages = LoadImages();

                // It means that user added some art
                if (Network.checkAddArt)
                {
                    checkListAllImages = true;
                }
                else
                {
                    checkListAllImages = false;
                }
            }
        }

        private List<String> LoadImages()
        {
            List<String> listFiles = new List<String>();

            if (Directory.Exists(picturesPath))
            {
                listFiles = FileSearch(picturesPath);
            }

            return listFiles;
        }

        private List<String> FileSearch(string pathDirectory)
        {
            List<String> allFiles = new List<String>();

            try
            {
                foreach (string fileNames in Directory.GetFiles(pathDirectory))
                {
                    allFiles.Add(fileNames);
                }

                foreach (string directoryNames in Directory.GetDirectories(pathDirectory))
                {
                    allFiles.AddRange(FileSearch(directoryNames));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return allFiles;
        }

        private void btnAddArt_Click(object sender, EventArgs e)
        {
            // Hide Main Form
            this.Hide();

            // Show Add Art Form
            AddArtForm addArtForm = new AddArtForm();
            addArtForm.Show();
        }

        private void btnCheckCategory_Click(object sender, EventArgs e)
        {
            // Hide Main Form
            this.Hide();

            // Show Check Category Form
            CheckCategoryForm checkCategoryForm = new CheckCategoryForm(checkListAllImages, listAllImages);

            try
            {
                // Condition when the check category form is not closed, then the object is still exists. Show Check Category Form.
                checkCategoryForm.Show();
            }
            catch (Exception)
            {
                // Condition when close the Check Category Form (the object of the Check Category Form itself will be disposed).

                // There is no code.
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Hide Main Form
            this.Hide();

            // Show Browse Form
            BrowseForm browseForm = new BrowseForm(listAllImages);

            try
            {
                // Condition when the browse form is not closed, then the object is still exists. Show Browse Form.
                browseForm.Show();
            }
            catch (Exception)
            {
                // Condition when close the Browse Form (the object of the Browse Form itself will be disposed)

                // There is no code.
            }
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Network.activationNetwork != null)
            {
                Network.activationNetwork.Save("BPNNBrain.net");
            }

            if (Network.distanceNetwork != null)
            {
                Network.distanceNetwork.Save("SOMBrain.net");
            }

            // Exit from the application
            Application.Exit();
        }
    }
}
