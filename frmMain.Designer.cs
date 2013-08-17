namespace DeleteToRecycleBin
{
    partial class frmMain
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
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnRecycle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OFD
            // 
            this.OFD.Filter = "*.*|All Files";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(151, 38);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(87, 27);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select file...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(12, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(370, 20);
            this.txtFile.TabIndex = 1;
            // 
            // btnRecycle
            // 
            this.btnRecycle.Location = new System.Drawing.Point(123, 82);
            this.btnRecycle.Name = "btnRecycle";
            this.btnRecycle.Size = new System.Drawing.Size(141, 46);
            this.btnRecycle.TabIndex = 2;
            this.btnRecycle.Text = "Recycle";
            this.btnRecycle.UseVisualStyleBackColor = true;
            this.btnRecycle.Click += new System.EventHandler(this.btnRecycle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 140);
            this.Controls.Add(this.btnRecycle);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Recycler";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnRecycle;
    }
}

