using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhotoRenamer
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            lblVersion.Text = "版本：" + Application.ProductVersion;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.littletools.cn");

            }
            catch
            {
                MessageBox.Show("无法访问http://www.LittleTools.cn");
            }
        }

        private void lnkSiteHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.littletools.cn");

            }
            catch
            {
                MessageBox.Show("无法访问http://www.LittleTools.cn");
            }
        }

        private void lnkProductHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.littletools.cn/product.aspx?productid=3");

            }
            catch
            {
                MessageBox.Show("无法访问http://www.LittleTools.cn");
            }
        }

        private void lnkAddComment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.littletools.cn/AddComment.aspx?productid=3");

            }
            catch
            {
                MessageBox.Show("无法访问http://www.LittleTools.cn");
            }
        }
    }
}