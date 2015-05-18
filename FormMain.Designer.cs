namespace PhotoRenamer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhotoDir = new System.Windows.Forms.Label();
            this.btnSelectPhotoDir = new System.Windows.Forms.Button();
            this.chkIncludeSubfolders = new System.Windows.Forms.CheckBox();
            this.btnBatchRename = new System.Windows.Forms.Button();
            this.btnManualRename = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Photo Folder:";
            // 
            // lblPhotoDir
            // 
            this.lblPhotoDir.AutoEllipsis = true;
            this.lblPhotoDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhotoDir.Location = new System.Drawing.Point(16, 28);
            this.lblPhotoDir.Name = "lblPhotoDir";
            this.lblPhotoDir.Size = new System.Drawing.Size(368, 21);
            this.lblPhotoDir.TabIndex = 1;
            this.lblPhotoDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectPhotoDir
            // 
            this.btnSelectPhotoDir.Location = new System.Drawing.Point(390, 28);
            this.btnSelectPhotoDir.Name = "btnSelectPhotoDir";
            this.btnSelectPhotoDir.Size = new System.Drawing.Size(71, 25);
            this.btnSelectPhotoDir.TabIndex = 2;
            this.btnSelectPhotoDir.Text = "&Open...";
            this.toolTip1.SetToolTip(this.btnSelectPhotoDir, "选择照片所在目录");
            this.btnSelectPhotoDir.UseVisualStyleBackColor = true;
            this.btnSelectPhotoDir.Click += new System.EventHandler(this.btnSelectPhotoDir_Click);
            // 
            // chkIncludeSubfolders
            // 
            this.chkIncludeSubfolders.AutoSize = true;
            this.chkIncludeSubfolders.Location = new System.Drawing.Point(240, 52);
            this.chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            this.chkIncludeSubfolders.Size = new System.Drawing.Size(144, 16);
            this.chkIncludeSubfolders.TabIndex = 3;
            this.chkIncludeSubfolders.Text = "Including subfolders";
            this.chkIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnBatchRename
            // 
            this.btnBatchRename.Location = new System.Drawing.Point(157, 88);
            this.btnBatchRename.Name = "btnBatchRename";
            this.btnBatchRename.Size = new System.Drawing.Size(131, 38);
            this.btnBatchRename.TabIndex = 4;
            this.btnBatchRename.Text = "&Batch Rename...";
            this.btnBatchRename.UseVisualStyleBackColor = true;
            this.btnBatchRename.Click += new System.EventHandler(this.btnBatchRename_Click);
            // 
            // btnManualRename
            // 
            this.btnManualRename.Location = new System.Drawing.Point(318, 88);
            this.btnManualRename.Name = "btnManualRename";
            this.btnManualRename.Size = new System.Drawing.Size(143, 38);
            this.btnManualRename.TabIndex = 5;
            this.btnManualRename.Text = "&Manually Rename...";
            this.btnManualRename.UseVisualStyleBackColor = true;
            this.btnManualRename.Click += new System.EventHandler(this.btnManualRename_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 101);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 12);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BatchStamper";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 143);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnManualRename);
            this.Controls.Add(this.btnBatchRename);
            this.Controls.Add(this.chkIncludeSubfolders);
            this.Controls.Add(this.btnSelectPhotoDir);
            this.Controls.Add(this.lblPhotoDir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoRenamer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhotoDir;
        private System.Windows.Forms.Button btnSelectPhotoDir;
        private System.Windows.Forms.CheckBox chkIncludeSubfolders;
        private System.Windows.Forms.Button btnBatchRename;
        private System.Windows.Forms.Button btnManualRename;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

