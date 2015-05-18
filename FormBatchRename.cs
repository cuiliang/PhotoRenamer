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
    public partial class FormBatchRename : Form
    {
        private string _photoFolder;

        public string PhotoFolder
        {
            get { return _photoFolder; }
            set { _photoFolder = value; }
        }

        private bool _includeSubfolders;

        public bool IncludeSubfolders
        {
            get { return _includeSubfolders; }
            set { _includeSubfolders = value; }
        }


        public FormBatchRename(string folder, bool includeSubfolder)
        {
            _photoFolder = folder;
            _includeSubfolders = includeSubfolder;

            InitializeComponent();

            UpdateControlState();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStartBatch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPrefix.Text))
            {
                if (txtPrefix.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >=0)
                {
                    MessageBox.Show("Invalid character in prefix!", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
            }

            if (MessageBox.Show("Are you sure to begin batch rename?", "PhotoReanmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            if (rbUsePhotoIndex.Checked)
            {
                try
                {
                    int startIndex = Convert.ToInt32(txtStartIndex.Text);
                }
                catch
                {
                    MessageBox.Show("Input an integer number into 'Start Index'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (rbUsePhotoDate.Checked)
            {
                //����������������
                string[] files = Directory.GetFiles(_photoFolder, "*", _includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                progressBar1.Visible = true;
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = files.Length;
                progressBar1.Value = 0;
                progressBar1.Step = 1;

                Cursor cr = Cursor.Current;
                //Cursor.Current = Cursors.WaitCursor;
                this.Cursor = Cursors.WaitCursor;
                btnStartBatch.Enabled = false;
                btnClose.Enabled = false;

                foreach (string file in files)
                {
                    Application.DoEvents();

                    progressBar1.PerformStep();

                    if (file.ToLower().EndsWith(".jpg")
                        || file.ToLower().EndsWith(".tiff")
                        || file.ToLower().EndsWith(".jpeg"))
                    {
                        //�ܹ���������
                        DateTime tmPhoto = ImageHelper.GetPhotoDate(file);
                        if (tmPhoto > DateTime.MinValue)
                        {
                            //�������ļ�
                            int i = 0;
                            string dstFileName = String.Empty;
                            string path = Path.GetDirectoryName(file);
                            string ext = Path.GetExtension(file);
                            while (true)
                            {
                                string formatString = "yyyyMMdd";
                                if (chkIncludeTime.Checked)
                                {
                                    formatString += "_HHmmss";
                                }

                                if (i == 0)
                                {
                                    dstFileName = txtPrefix.Text + tmPhoto.ToString(formatString);

                                }
                                else
                                {
                                    dstFileName = txtPrefix.Text + tmPhoto.ToString(formatString + "_") + String.Format("{0:D}", i);
                                }

                                dstFileName = Path.Combine(path, dstFileName) + ext;
                                if (!File.Exists(dstFileName))
                                {
                                    break;
                                }
                                else
                                {
                                    i++;
                                }
                            }



                            if (!String.IsNullOrEmpty(dstFileName))
                            {
                                File.Move(file, dstFileName);
                            }
                        }
                        else
                        {
                            //�޷���ȡ�������ڣ�����
                            continue;
                        }
                    }
                    else
                    {
                        //�����д�������exif���ļ���ʽ
                        continue;
                    }


                }

                progressBar1.Visible = false;
                this.Cursor = cr;
                btnStartBatch.Enabled = true;
                btnClose.Enabled = true;

                MessageBox.Show("Complete!");
            }
            else
            {
                //�����������
                DirectoryInfo dir = new DirectoryInfo(_photoFolder);
                FileInfo[] files = dir.GetFiles("*", _includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                ImageHelper.QuickSort(files, 0, files.Length - 1);


                //������
                int nIndex = Convert.ToInt32(txtStartIndex.Text);

                string indexFormatString = "{0:" + (new string('0', Convert.ToInt32(numDigiNum.Value))) + "}";

                progressBar1.Visible = true;
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = files.Length;
                progressBar1.Value = 0;
                progressBar1.Step = 1;

                Cursor cr = Cursor.Current;
                this.Cursor = Cursors.WaitCursor;
                btnStartBatch.Enabled = false;
                btnClose.Enabled = false;

                foreach (FileInfo file in files)
                {
                    Application.DoEvents();

                    progressBar1.PerformStep();


                    string dstName = Path.Combine(Path.GetDirectoryName(file.FullName), txtPrefix.Text + String.Format(indexFormatString, nIndex))
                        + Path.GetExtension(file.Name);

                    nIndex++;

                    File.Move(file.FullName, dstName);
                }

                progressBar1.Visible = false;
                this.Cursor = cr;
                btnStartBatch.Enabled = true;
                btnClose.Enabled = true;

                MessageBox.Show("Complete!");
            }

        }

        /// <summary>
        /// ���¿ؼ���״̬
        /// </summary>
        private void UpdateControlState()
        {
            chkIncludeTime.Enabled = rbUsePhotoDate.Checked;
            txtStartIndex.Enabled = rbUsePhotoIndex.Checked;
            numDigiNum.Enabled = rbUsePhotoIndex.Checked;
        }

        private void rbUsePhotoDate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlState();
        }
    }
}