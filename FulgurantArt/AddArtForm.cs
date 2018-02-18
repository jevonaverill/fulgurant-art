using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// New References
using System.IO;

namespace FulgurantArt
{
    public partial class AddArtForm : Form
    {
        List<String> listImageNames;
        List<String> listCategories;

        String pathDirectory;
        String newImageFileName;
        String categories;  

        public AddArtForm()
        {
            InitializeComponent();

            listImageNames = new List<String>();
            listCategories = new List<String>();

            pathDirectory = "";
            newImageFileName = "";
            categories = "";

            Network.checkAddArt = false;

            // Load Categories
            LoadCategories();
        }

        // If user clicks Back Link Label, then go back to Main Form.
        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide Add Art Form
            this.Hide();

            // Show Main Form
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnAddNewArt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files | *.jpg; *jpeg; *.png";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in openFileDialog.FileNames)
                {
                    listImageNames.Add(item);

                    if (listViewArt.FindItemWithText(item) == null)
                    {
                        imageListArt.Images.Add(item, new Bitmap(item));

                        ListViewItem listViewItem = new ListViewItem(Path.GetFileName(item), item);
                        listViewArt.Items.Add(listViewItem);
                    }
                }
            }

            if (listImageNames.Count == 0 || cmbCategory.SelectedIndex < 0)
            {
                btnSubmitArt.Visible = false;
            }
            else
            {
                btnSubmitArt.Visible = true;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == 0)
            {
                txtArt.Visible = true;
                txtArt.Text = "";
                btnSubmitArt.Visible = false;
            }
            else
            {
                txtArt.Visible = false;

                if (listImageNames.Count == 0 || cmbCategory.SelectedIndex < 0)
                {
                    btnSubmitArt.Visible = false;
                }
                else
                {
                    btnSubmitArt.Visible = true;
                }
            }
        }

        private void txtArt_TextChanged(object sender, EventArgs e)
        {
            // If there are no selected images in New Art List View or Category Combo Box is not selected, then hide Submit Art Button
            if (listImageNames.Count == 0 || cmbCategory.SelectedIndex < 0)
            {
                btnSubmitArt.Visible = false;
            }

            // If there are no selected images in New Art List View or Category Combo Box is not selected, then hide Submit Art Button
            else if (cmbCategory.SelectedIndex == 0 && txtArt.Text.Trim().Equals(""))
            {
                btnSubmitArt.Visible = false;
            }

            // Otherwise, then show Submit Art Button.
            else
            {
                btnSubmitArt.Visible = true;
            }
        }

        private void btnSubmitArt_Click(object sender, EventArgs e)
        {
            foreach (var imageFileName in listImageNames)
            {
                if (cmbCategory.SelectedIndex == 0)
                {
                    pathDirectory = Application.StartupPath + @"\pictures\" + txtArt.Text.Trim();

                    if (!Directory.Exists(pathDirectory))
                    {
                        Directory.CreateDirectory(pathDirectory);
                    }

                    // Save File
                    newImageFileName = Path.Combine(pathDirectory, Path.GetFileName(imageFileName));
                    File.Copy(imageFileName, newImageFileName, true);
                }
                else
                {
                    pathDirectory = Application.StartupPath + @"\pictures\" + cmbCategory.SelectedItem.ToString();

                    if (!Directory.Exists(pathDirectory))
                    {
                        Directory.CreateDirectory(pathDirectory);
                    }

                    // Save File
                    newImageFileName = Path.Combine(pathDirectory, Path.GetFileName(imageFileName));
                    File.Copy(imageFileName, newImageFileName, true);
                }
            }

            MessageBox.Show("Art Submitted!");

            if (Network.loadActivationNetwork != null || Network.loadDistanceNetwork != null)
            {
                Network.checkAddArt = true;
            }
            else
            {
                Network.checkAddArt = false;
            }

            // Clear Form
            ClearForm();

            // Load Categories
            LoadCategories();
        }

        private void ClearForm()
        {
            listImageNames.Clear();
            listViewArt.Clear();

            cmbCategory.SelectedIndex = -1;

            txtArt.Text = "";

            txtArt.Visible = false;
            btnSubmitArt.Visible = false;
        }

        private void LoadCategories()
        {
            List<String> listDirectories = new List<String>();

            String picturesPath = Application.StartupPath + @"\pictures";

            if (Directory.Exists(picturesPath))
            {
                listDirectories = DirectorySearch(picturesPath);
            }

            // Clear Category Combo Box.
            cmbCategory.Items.Clear();

            // Fill Category Combo Box with “Add New Category” option.
            cmbCategory.Items.Insert(0, "Add New Category");

            if (listDirectories.Count > 0)
            {
                int categoryIndex = 0;

                foreach (String item in listDirectories)
                {
                    categoryIndex++;

                    // Append Category Combo Box with all categories available.
                    cmbCategory.Items.Insert(categoryIndex, item);
                }
            }
        }

        private List<String> DirectorySearch(string pathDirectory)
        {
            List<String> allDirectories = new List<String>();

            try
            {
                foreach (string directoryNames in Directory.GetDirectories(pathDirectory))
                {
                    categories = Path.GetFileName(directoryNames);

                    allDirectories.Add(categories);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return allDirectories;
        }

        private void listViewArt_Click(object sender, EventArgs e)
        {
            listImageNames.Clear();

            foreach (ListViewItem item in listViewArt.SelectedItems)
            {
                listImageNames.Add(item.ImageKey);
            }
        }
    }
}