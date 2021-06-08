using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderFileTask
{
    public partial class FolderFile : Form
    {
        public FolderFile()
        {
            InitializeComponent();
        }

        public DirectoryInfo[] folders;
        public FileInfo[] files;
        public string path;
        public string openedFile;

        private void FolderFile_Load(object sender, EventArgs e)
        {
            cmbFileExtension.SelectedIndex = 0;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                DirectoryInfo dr = new DirectoryInfo(path);

                folders = dr.GetDirectories();
                files = dr.GetFiles();

                dataGridView.Rows.Clear();
                foreach (var item in folders)
                    dataGridView.Rows.Add(item.Name, "Folder");
                foreach (var item in files)
                    dataGridView.Rows.Add(item.Name, item.Extension);
            }
            btnCreateFile.Enabled = true;
            btnCreateFolder.Enabled = true;
        }
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Create($"{path}\\{txtFile.Text}{cmbFileExtension.Text}");
            dataGridView.Rows.Add(Path.GetFileName(fs.Name), Path.GetExtension(fs.Name));
            fs.Close();
        }
        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = Directory.CreateDirectory($"{path}\\{txtFolder.Text}");
            dataGridView.Rows.Add(Path.GetFileName(directoryInfo.Name), "Folder");
        }
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                #region 2 versiya
                //if (File.Exists(openedFile))
                //{
                //    StreamWriter sw = new StreamWriter(openedFile);
                //    sw.WriteLine(richTextBox.Text);
                //    sw.Close();
                //}
                #endregion
                richTextBox.SaveFile(openedFile, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Changes saved in same file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                openedFile = path + "\\" + dataGridView.CurrentRow.Cells["gridName"].Value.ToString();
                if (File.Exists(openedFile))
                {
                    richTextBox.LoadFile(openedFile, RichTextBoxStreamType.PlainText);
                    btnSave.Enabled = false;
                }
                #region 2. versiya
                //if (File.Exists(openedFile))
                //{
                //    StreamReader sr = new StreamReader(openedFile);
                //    richTextBox.Text = sr.ReadToEnd();
                //    sr.Close();
                //    btnSave.Enabled = false;
                //}
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
