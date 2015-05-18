namespace PhotoRenamer
{
    partial class FormManualRename
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
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOldName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.lblCurrImageIndex = new System.Windows.Forms.Label();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(374, 391);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(226, 21);
            this.txtNewName.TabIndex = 4;
            this.txtNewName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewName_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "New Name:";
            // 
            // txtOldName
            // 
            this.txtOldName.Location = new System.Drawing.Point(99, 391);
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.ReadOnly = true;
            this.txtOldName.Size = new System.Drawing.Size(199, 21);
            this.txtOldName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Current Name:";
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.Gray;
            this.pnlPreview.Controls.Add(this.picPreview);
            this.pnlPreview.Location = new System.Drawing.Point(12, 11);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(588, 351);
            this.pnlPreview.TabIndex = 0;
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(17, 59);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(100, 46);
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // lblCurrImageIndex
            // 
            this.lblCurrImageIndex.AutoSize = true;
            this.lblCurrImageIndex.Location = new System.Drawing.Point(327, 367);
            this.lblCurrImageIndex.Name = "lblCurrImageIndex";
            this.lblCurrImageIndex.Size = new System.Drawing.Size(101, 12);
            this.lblCurrImageIndex.TabIndex = 9;
            this.lblCurrImageIndex.Text = "第几张  / 共几张";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Location = new System.Drawing.Point(524, 363);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(75, 21);
            this.btnNextImage.TabIndex = 7;
            this.btnNextImage.Text = "&Next";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Location = new System.Drawing.Point(443, 363);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(75, 21);
            this.btnPrevImage.TabIndex = 8;
            this.btnPrevImage.Text = "&Previous";
            this.btnPrevImage.UseVisualStyleBackColor = true;
            this.btnPrevImage.Click += new System.EventHandler(this.btnPrevImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(408, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Press \'Enter\' to save new name";
            // 
            // FormManualRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.lblCurrImageIndex);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOldName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManualRename";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "manually rename photos";
            this.Load += new System.EventHandler(this.FormManualRename_Load);
            this.Activated += new System.EventHandler(this.FormManualRename_Activated);
            this.pnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOldName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label lblCurrImageIndex;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.Label label1;
    }
}