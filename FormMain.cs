using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PhotoRenamer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBatchRename_Click(object sender, EventArgs e)
        {
            if (CheckDirectory())
            {
                FormBatchRename frm = new FormBatchRename(lblPhotoDir.Text, chkIncludeSubfolders.Checked);
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// ¼ì²éÕÕÆ¬Ä¿Â¼
        /// </summary>
        private bool CheckDirectory()
        {
            if (String.IsNullOrEmpty(lblPhotoDir.Text))
            {
                MessageBox.Show("Please select the photo folder!", "PhotoRenamer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!Directory.Exists(lblPhotoDir.Text))
            {
                MessageBox.Show("The folder does not exists!", "PhotoRenamer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnManualRename_Click(object sender, EventArgs e)
        {
            if (CheckDirectory())
            {
                FormManualRename frm = new FormManualRename(lblPhotoDir.Text, chkIncludeSubfolders.Checked);
                frm.ShowDialog();
            }
        }

        private void btnSelectPhotoDir_Click(object sender, EventArgs e)
        {
            toolTip1.Hide(btnSelectPhotoDir);

            string oldDir = String.Empty;
            if (String.IsNullOrEmpty(lblPhotoDir.Text)
                || (!Directory.Exists(lblPhotoDir.Text)))
            {
                oldDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }
            else
            {
                oldDir = lblPhotoDir.Text;
            }

            folderBrowserDialog1.Description = "Select photo folder:";
            folderBrowserDialog1.SelectedPath = oldDir;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblPhotoDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Activate();
            toolTip1.Show("Please select the photo folder!", btnSelectPhotoDir, btnSelectPhotoDir.Width / 2, btnSelectPhotoDir.Height / 2, 5000);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.batchstamper.com");

            }
            catch
            {
                MessageBox.Show("Can not visit http://www.batchstamper.com");
            }
        }
    }
}