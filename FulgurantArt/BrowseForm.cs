using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// New References
using System.IO;

namespace FulgurantArt
{
    public partial class BrowseForm : Form
    {
        List<String> checkImages;
        List<String> listFiles;

        String picturesPath;
        String pathDirectory;
        String groups;

        public BrowseForm(List<String> listAllImages)
        {
            InitializeComponent();

            picturesPath = "";
            pathDirectory = "";
            groups = "";

            checkImages = new List<String>();
            listFiles = new List<String>();

            listFiles = listAllImages;

            if (listFiles.Count <= 0)
            {
                // If there is no image in the list, then show warning message and go back to Main Form.
                MessageBox.Show("Add some art first!");

                // Show Main Form
                MainForm mainForm = new MainForm();
                mainForm.Show();

                // Close Browse Form
                this.Close();
            }
            else
            {
                // Otherwise, then show all images grouped by their category in the list to Art List View.
                checkImages = LoadImages();
            }
        }

        private List<String> LoadImages()
        {
            picturesPath = Application.StartupPath + @"\pictures";

            if (Directory.Exists(picturesPath))
            {
                if (listFiles.Count != 0)
                { 
                    String tempGroups = "";

                    int groupIndex = -1;

                    foreach (var item in listFiles)
                    {
                        if (listViewArt.FindItemWithText(item) == null)
                        {
                            imageListArt.Images.Add(item, new Bitmap(item));

                            pathDirectory = Path.GetDirectoryName(item);
                            groups = Path.GetFileName(pathDirectory);

                            if (tempGroups != groups)
                            {
                                groupIndex++;

                                listViewArt.Groups.Add("groupKey" + groupIndex, groups);
                            }

                            ListViewItem listViewItem = new ListViewItem(Path.GetFileName(item), item, listViewArt.Groups[groupIndex]);

                            listViewArt.Items.Add(listViewItem);
                        }

                        tempGroups = groups;
                    }
                }
            }

            return listFiles;
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

        // If user double clicks in Art List View, then go to the Art Detail Form showing the selected image.
        private void listViewArt_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewArt.SelectedItems)
            {
                // Hide Browse Form
                this.Hide();

                // Show Art Detail Form
                ArtDetailForm artDetailForm = new ArtDetailForm(listFiles, item.ImageKey, item.Text);
                artDetailForm.Show();
            }
        }
    }
}
