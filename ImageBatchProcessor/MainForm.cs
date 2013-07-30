using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace ImageBatchProcessor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (SelectFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSelectFolder.Text = SelectFolder.SelectedPath;
            }
        }

        private void btnToFolder_Click(object sender, EventArgs e)
        {
            if (ToFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtToFolder.Text = ToFolder.SelectedPath;
            }
        }

        private void btnStartProcessing_Click(object sender, EventArgs e)
        {
            btnStartProcessing.Enabled = false;
            List<string> filePaths = new List<string>();

            if (string.IsNullOrEmpty(txtSelectFolder.Text) == false && string.IsNullOrEmpty(txtToFolder.Text) == false)
            {
                if (txtSelectFolder.Text != txtToFolder.Text)
                {
                    if (Directory.Exists(txtSelectFolder.Text) == true)
                    {
                        if (Directory.Exists(txtToFolder.Text) == true)
                        {
                            filePaths = GetAllFiles(txtSelectFolder.Text);
                        }
                        else
                        {
                            //To folder is not correct.
                            MessageBox.Show("Please choose the new image folder in 'Save Image Folder'.");
                        }
                    }
                    else
                    {
                        //Selected folder is not correct.
                        MessageBox.Show("Please choose the image base folder in 'Original Image Folder'.");
                    }
                }
                else
                {
                    //Two folders can not be same.
                    MessageBox.Show("The 'Original Image Folder' can not be same with the 'Save Image Folder'.");
                }
            }
            else
            {
                //Must select folders.
                MessageBox.Show("Please choose the image base folder in 'Original Image Folder' and the new image folder in 'Save Image Folder'.");
            }
            foreach (var filePath in filePaths)
            {
                //GET SMALL IMAGE
                string inputImagePath = filePath;
                string outputImagePath = filePath.Replace(txtSelectFolder.Text, txtToFolder.Text);
                string folder = GetFolder(outputImagePath);
                string fileName = filePath.Substring(filePath.LastIndexOf('\\') + 1);

                double zoom = 0;
                double zoomInt = Convert.ToDouble(nudZoom.Value);
                zoom = zoomInt / 100;

                if (cbReplace.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtReplaceFrom.Text) == false && string.IsNullOrEmpty(txtReplaceTo.Text) == false)
                    {
                        fileName.Replace(txtReplaceFrom.Text, txtReplaceTo.Text);
                    }
                    else
                    {
                        //Can not be null.
                        MessageBox.Show("Selected file name change options can not be empty.");
                    }
                }

                if (cbInsertInStart.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtInsertStart.Text) == false)
                    {
                        fileName = txtInsertStart.Text + fileName;
                    }
                    else
                    {
                        //Can not be null.
                        MessageBox.Show("Selected file name change options can not be empty.");
                    }
                }

                if (cbInsertInEnd.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtInsertEnd.Text) == false)
                    {
                        fileName = fileName + txtInsertEnd.Text;
                    }
                    else
                    {
                        //Can not be null.
                        MessageBox.Show("Selected file name change options can not be empty.");
                    }
                }

                if (cbRemove.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtRemove.Text) == false)
                    {
                        fileName = fileName.Replace(txtRemove.Text, "");
                    }
                    else
                    {
                        //Can not be null.
                        MessageBox.Show("Selected file name change options can not be empty.");
                    }
                }

                outputImagePath = folder + "\\" + fileName;

                #region Convert Image
                // Load image.
                System.Drawing.Image oldImage = System.Drawing.Image.FromFile(inputImagePath);

                // Compute thumbnail size.
                Size thumbnailSize = GetThumbnailSize(oldImage, zoom);
                // Get thumbnail.
                Bitmap newImage = new Bitmap(thumbnailSize.Width, thumbnailSize.Height);
                using (Graphics gr = Graphics.FromImage(newImage))
                {
                    gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.DrawImage(oldImage, new Rectangle(0, 0, thumbnailSize.Width, thumbnailSize.Height));
                }

                newImage.Save(outputImagePath);
                #endregion

                lbMessage.Items.Add(DateTime.Now.ToString() + ": " + filePath);
            }
            btnStartProcessing.Enabled = true;
            MessageBox.Show("Convert successful!");
            txtSelectFolder.Text = string.Empty;
            txtToFolder.Text = string.Empty;
        }

        private List<string> GetAllFiles(string baseFilePath)
        {
            List<string> result = new List<string>();
            var temp = Directory.GetFiles(baseFilePath).ToList();
            result.AddRange(temp.Where(f => f.ToLower().Contains(".jpg") || f.ToLower().Contains(".png") || f.ToLower().Contains(".jpeg") || f.ToLower().Contains(".bmp")).ToList());
            List<string> subDirectories = Directory.GetDirectories(baseFilePath).ToList();
            foreach (var subDirectory in subDirectories)
            {
                result.AddRange(GetAllFiles(subDirectory));
            }
            return result;
        }

        private Size GetThumbnailSize(Image original, double factor)
        {
            int originalWidth = original.Width;
            int originalHeight = original.Height;

            // Return thumbnail size.
            return new Size((int)(originalWidth * factor), (int)(originalHeight * factor));
        }

        private string GetFolder(string filePath)
        {
            string result = string.Empty;
            result = filePath.Substring(0, filePath.LastIndexOf('\\'));
            if (Directory.Exists(result) == false)
            {
                result = Directory.CreateDirectory(result).FullName;
            }
            return result;
        }

        private void cbReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReplace.Checked == true)
            {
                txtReplaceFrom.ReadOnly = false;
                txtReplaceTo.ReadOnly = false;
                txtReplaceFrom.Focus();
            }
            else
            {
                txtReplaceFrom.Text = string.Empty;
                txtReplaceFrom.ReadOnly = true;
                txtReplaceTo.Text = string.Empty;
                txtReplaceTo.ReadOnly = true;
            }
        }

        private void cbInsertInStart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInsertInStart.Checked == true)
            {
                txtInsertStart.ReadOnly = false;
                txtInsertStart.Focus();
            }
            else
            {
                txtInsertStart.Text = string.Empty;
                txtInsertStart.ReadOnly = true;
            }
        }

        private void cbInsertInEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInsertInEnd.Checked == true)
            {
                txtInsertEnd.ReadOnly = false;
                txtInsertEnd.Focus();
            }
            else
            {
                txtInsertEnd.Text = string.Empty;
                txtInsertEnd.ReadOnly = true;
            }
        }

        private void cbRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemove.Checked == true)
            {
                txtRemove.ReadOnly = false;
                txtRemove.Focus();
            }
            else
            {
                txtRemove.Text = string.Empty;
                txtRemove.ReadOnly = true;
            }
        }

    }
}
