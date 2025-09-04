using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Diagnostics;

namespace Unzipper_main
{
    public partial class Form1 : Form
    {

        string dirPath = Path.Combine(Application.StartupPath, "unzippingFolder");
        string exportedPath = Path.Combine(Application.StartupPath, "exported");
        public Form1()
        {
            InitializeComponent();
        }
        private void updateContentFolders()
        {
            txtBoxExport.Text = "\r";
            txtBoxUnzip.Text = "\r";

            txtBoxExport.Text = "";
            txtBoxUnzip.Text = "";
            foreach (string row in Directory.GetFileSystemEntries(exportedPath))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    string extension = Path.GetExtension(row).ToLower();
                    if (string.IsNullOrEmpty(extension))
                    {
                        extension = "other/folder";
                    }
                    txtBoxExport.Text += Path.GetFileNameWithoutExtension(row).ToString() + $"   (type: {extension})" + Environment.NewLine;
                }
            }
            foreach (string row in Directory.GetFileSystemEntries(dirPath))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    string extension = Path.GetExtension(row).ToLower();
                    if (string.IsNullOrEmpty(extension))
                    {
                        extension = "other/folder";
                    }
                    txtBoxUnzip.Text += Path.GetFileNameWithoutExtension(row).ToString() + $"   (type: {extension})" + Environment.NewLine;
                }
            }
        }

        private void exportFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Explorer.exe", exportedPath);
            }
            catch
            {
                MessageBox.Show("Usable folder coulnt be found");
            }
        }

        private void unzipFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Explorer.exe", dirPath);
            }
            catch
            {
                MessageBox.Show("Usable folder coulnt be found");
            }
        }

        private void folderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateContentFolders();
        }

        private void exportFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resultchck = MessageBox.Show("Are you sure you want to delete all files in export folder?",
                          "Confirm Deletion",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning);

            if (resultchck == DialogResult.Yes)
            {
                DialogResult resultdblchck = MessageBox.Show("Are you sure, this cannot be undone?",
                                      "Confirm Deletion",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
                if (resultdblchck == DialogResult.Yes)
                {
                    foreach (string entry in Directory.GetFileSystemEntries(exportedPath))
                    {
                        if (File.Exists(entry))
                        {
                            File.Delete(entry);
                        }
                        else if (Directory.Exists(entry))
                        {
                            Directory.Delete(entry, true);
                        }
                    }
                    updateContentFolders();
                    MessageBox.Show("Export folder has been deleted by user");
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Console.WriteLine("Clicked");

                if (Directory.Exists(dirPath) && Directory.Exists(exportedPath))
                {
                    int non_zip = 0;
                    int files_found = 0;
                    foreach (string file in Directory.GetFiles(dirPath))
                    {
                        string extension = Path.GetExtension(file).ToLower();
                        if (extension == ".zip")
                        {
                            string name = Path.GetFileNameWithoutExtension(file);
                            string actualExportPath = $"{exportedPath}/{name}";
                            if (!Directory.Exists(actualExportPath))
                            {
                                ZipFile.ExtractToDirectory(file, actualExportPath);
                            }
                            else
                            {
                                MessageBox.Show($"There was found a same named folder: item skipped {actualExportPath}");
                            }
                            files_found++;
                        }
                        else
                        {
                            non_zip++;
                        }
                    }
                    if (non_zip > 0)
                    {
                        MessageBox.Show($"There was {non_zip} amount of other files found");
                    }
                    if (files_found < 1)
                    {
                        MessageBox.Show($"Cannot unzip. No files in unzip directory");
                    }
                    updateContentFolders();
                }
                else
                {
                    MessageBox.Show("Dir doesnt exist! Created a new one");
                    Directory.CreateDirectory(dirPath);
                    Directory.CreateDirectory(exportedPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred: {ex.Message}");
            }
        }

        private void unzipFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resultchck = MessageBox.Show("Are you sure you want to delete all files in Unzip folder?",
                          "Confirm Deletion",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning);

            if (resultchck == DialogResult.Yes)
            {
                DialogResult resultdblchck = MessageBox.Show("Are you sure, this cannot be undone?",
                                      "Confirm Deletion",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
                if (resultdblchck == DialogResult.Yes)
                {
                    foreach (string entry in Directory.GetFileSystemEntries(dirPath))
                    {
                        if (File.Exists(entry))
                        {
                            File.Delete(entry);
                        }
                        else if (Directory.Exists(entry))
                        {
                            Directory.Delete(entry, true);
                        }
                    }
                    updateContentFolders();
                    MessageBox.Show("Unzip folder has been deleted by user");
                }
            }
        }

        private void unzipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //empty text
            txtBoxUnzip.Text = "\r";
            txtBoxUnzip.Text = "";
            //loops thru everything and checks their file type to show on container
            foreach (string row in Directory.GetFileSystemEntries(dirPath))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    string extension = Path.GetExtension(row).ToLower();
                    if (string.IsNullOrEmpty(extension))
                    {
                        extension = "other/folder";
                    }
                    txtBoxUnzip.Text += Path.GetFileNameWithoutExtension(row).ToString() + $"   (type: {extension})" + Environment.NewLine;
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxExport.Text = "\r";
            txtBoxExport.Text = "";
            foreach (string row in Directory.GetFileSystemEntries(exportedPath))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    string extension = Path.GetExtension(row).ToLower();
                    if (string.IsNullOrEmpty(extension))
                    {
                        extension = "other/folder";
                    }
                    txtBoxExport.Text += Path.GetFileNameWithoutExtension(row).ToString() + $"   (type: {extension})" + Environment.NewLine;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateContentFolders();
        }
    }
}
