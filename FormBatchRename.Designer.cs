namespace PhotoRenamer
{
    partial class FormBatchRename
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
            this.btnStartBatch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbUsePhotoIndex = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbUsePhotoDate = new System.Windows.Forms.RadioButton();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.chkIncludeTime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numDigiNum = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numDigiNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartBatch
            // 
            this.btnStartBatch.Location = new System.Drawing.Point(161, 138);
            this.btnStartBatch.Name = "btnStartBatch";
            this.btnStartBatch.Size = new System.Drawing.Size(159, 38);
            this.btnStartBatch.TabIndex = 10;
            this.btnStartBatch.Text = "Start Batch Renmae";
            this.btnStartBatch.UseVisualStyleBackColor = true;
            this.btnStartBatch.Click += new System.EventHandler(this.btnStartBatch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prefix:";
            // 
            // rbUsePhotoIndex
            // 
            this.rbUsePhotoIndex.AutoSize = true;
            this.rbUsePhotoIndex.Location = new System.Drawing.Point(231, 60);
            this.rbUsePhotoIndex.Name = "rbUsePhotoIndex";
            this.rbUsePhotoIndex.Size = new System.Drawing.Size(251, 16);
            this.rbUsePhotoIndex.TabIndex = 5;
            this.rbUsePhotoIndex.Text = "Photo index number£¨001¡¢002¡¢003...£©";
            this.rbUsePhotoIndex.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(174, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "+";
            // 
            // rbUsePhotoDate
            // 
            this.rbUsePhotoDate.AutoSize = true;
            this.rbUsePhotoDate.Checked = true;
            this.rbUsePhotoDate.Location = new System.Drawing.Point(231, 16);
            this.rbUsePhotoDate.Name = "rbUsePhotoDate";
            this.rbUsePhotoDate.Size = new System.Drawing.Size(155, 16);
            this.rbUsePhotoDate.TabIndex = 3;
            this.rbUsePhotoDate.TabStop = true;
            this.rbUsePhotoDate.Text = "Photo date£¨yyyymmdd£©";
            this.rbUsePhotoDate.UseVisualStyleBackColor = true;
            this.rbUsePhotoDate.CheckedChanged += new System.EventHandler(this.rbUsePhotoDate_CheckedChanged);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(11, 39);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(144, 21);
            this.txtPrefix.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(337, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 38);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start index:";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(337, 80);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(58, 21);
            this.txtStartIndex.TabIndex = 7;
            this.txtStartIndex.Text = "1";
            // 
            // chkIncludeTime
            // 
            this.chkIncludeTime.AutoSize = true;
            this.chkIncludeTime.Location = new System.Drawing.Point(256, 38);
            this.chkIncludeTime.Name = "chkIncludeTime";
            this.chkIncludeTime.Size = new System.Drawing.Size(162, 16);
            this.chkIncludeTime.TabIndex = 4;
            this.chkIncludeTime.Text = "Time£¨yyyymmdd_hhmmss£©";
            this.chkIncludeTime.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digit num:";
            // 
            // numDigiNum
            // 
            this.numDigiNum.Location = new System.Drawing.Point(337, 102);
            this.numDigiNum.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numDigiNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDigiNum.Name = "numDigiNum";
            this.numDigiNum.Size = new System.Drawing.Size(58, 21);
            this.numDigiNum.TabIndex = 9;
            this.numDigiNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 155);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(144, 21);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // FormBatchRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 188);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numDigiNum);
            this.Controls.Add(this.chkIncludeTime);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStartBatch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbUsePhotoIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbUsePhotoDate);
            this.Controls.Add(this.txtPrefix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBatchRename";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Batch Rename";
            ((System.ComponentModel.ISupportInitialize)(this.numDigiNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartBatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbUsePhotoIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbUsePhotoDate;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.CheckBox chkIncludeTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDigiNum;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}