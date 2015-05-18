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
    public partial class FormManualRename : Form
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

        IList<string> _files = new List<string>();  //图片文件列表
        int _fileIndex = 0;     //当前正在改名的图片序号

        public FormManualRename(string folder, bool includeSubfolder)
        {
            _photoFolder = folder;
            _includeSubfolders = includeSubfolder;


            InitializeComponent();
        }

        private void FormManualRename_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(_photoFolder, "*", _includeSubfolders? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            foreach(string file in files)
            {
                string ext = Path.GetExtension(file).ToLower();
                if (ext == ".jpg"
                    || ext == ".jpeg"
                    || ext == ".tiff"
                    || ext == ".bmp"
                    || ext == ".gif"
                    || ext == ".png")
                {
                    _files.Add(file);
                }
            }

            if (_files.Count == 0)
            {
                MessageBox.Show("No photo in the folder!", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Close();
                return;
            }

            LoadImage(_files[0]);

            UpdateNavButtons();

        }


        /// <summary>
        /// 装再一张照片
        /// </summary>
        /// <param name="file"></param>
        private void LoadImage(string file)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            Image img = Image.FromFile(file);

            Bitmap bmp = new Bitmap(img);
            img.Dispose();

            picPreview.Image = bmp;
            txtOldName.Text = Path.GetFileNameWithoutExtension(file);
            txtNewName.Text = txtOldName.Text;
            //txtNewName.Select(txtNewName.Text.Length - 1, 0);


            picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            //change location 
            const int Margin = 0;
            double rPic = (double)picPreview.Image.Width / picPreview.Image.Height;
            double rPanel = (double)pnlPreview.Size.Width / pnlPreview.Size.Height;

            pnlPreview.SuspendLayout();
            if (rPic < rPanel)
            {	//!! use Height
                picPreview.Height = pnlPreview.Size.Height - 2 * Margin - 2;
                picPreview.Width = (int)(pnlPreview.Size.Height * rPic);
                picPreview.Location = new Point((pnlPreview.Size.Width - picPreview.Width) / 2, Margin);
            }
            else
            {
                picPreview.Width = pnlPreview.Size.Width - 2 * Margin - 2;
                picPreview.Height = (int)(pnlPreview.Size.Width / rPic);
                picPreview.Location = new Point(Margin, (pnlPreview.Size.Height - picPreview.Height) / 2);
            }
            pnlPreview.ResumeLayout();

            Cursor.Current = cr;
        }

        private void UpdateNavButtons()
        {
            btnPrevImage.Enabled = _fileIndex > 0;
            btnNextImage.Enabled = _fileIndex < (_files.Count - 1);
            lblCurrImageIndex.Text = "" + (_fileIndex + 1).ToString() + " of " + _files.Count.ToString() + " photos";
        }

        private void btnPrevImage_Click(object sender, EventArgs e)
        {
            if (txtOldName.Text != txtNewName.Text)
            {
                //文件名改了
                DoSaveName();
            }

            if (_fileIndex > 0)
            {
                _fileIndex--;
                LoadImage(_files[_fileIndex]);
                UpdateNavButtons();
                txtNewName.Focus();
                txtNewName.SelectAll();
            }
            else
            {
                MessageBox.Show("Current is the first photo!");
            }
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            if (txtOldName.Text != txtNewName.Text)
            {
                //文件名改了
                DoSaveName();
            }

            if (_fileIndex < _files.Count - 1)
            {
                _fileIndex++;
                LoadImage(_files[_fileIndex]);
                UpdateNavButtons();
                txtNewName.Focus();
                txtNewName.SelectAll();
            }
            else
            {
                MessageBox.Show("Current is the last photo!");
            }
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            DoSaveName();
        }

        /// <summary>
        /// 保存新文件名,返回是否保存成功
        /// </summary>
        private bool DoSaveName()
        {
            try
            {
                string newName = Path.Combine(Path.GetDirectoryName(_files[_fileIndex]), txtNewName.Text) + Path.GetExtension(_files[_fileIndex]);
                File.Move(_files[_fileIndex], newName);

                _files[_fileIndex] = newName;
                txtOldName.Text = Path.GetFileNameWithoutExtension(newName);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private void txtNewName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOldName.Text != txtNewName.Text)
                {
                    //文件名改了
                    if (DoSaveName())
                    {

                        if (e.Shift)
                        {
                            btnPrevImage_Click(null, null);
                        }
                        else
                        {
                            btnNextImage_Click(null, null);
                        }
                    }
                }
                else
                {
                    //文件没改
                    if (e.Shift)
                    {
                        btnPrevImage_Click(null, null);
                    }
                    else
                    {
                        btnNextImage_Click(null, null);
                    }
                }
            }
        }

        private void FormManualRename_Activated(object sender, EventArgs e)
        {
            txtNewName.Focus();
        }
    }
}