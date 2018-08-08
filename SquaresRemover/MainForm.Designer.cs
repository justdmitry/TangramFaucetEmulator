namespace SquaresRemover
{
    partial class MainForm
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
            this.originalPicture = new System.Windows.Forms.PictureBox();
            this.processedPicture = new System.Windows.Forms.PictureBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.processed2Picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed2Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPicture
            // 
            this.originalPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.originalPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.originalPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPicture.Location = new System.Drawing.Point(12, 80);
            this.originalPicture.Name = "originalPicture";
            this.originalPicture.Size = new System.Drawing.Size(226, 226);
            this.originalPicture.TabIndex = 0;
            this.originalPicture.TabStop = false;
            // 
            // processedPicture
            // 
            this.processedPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processedPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.processedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedPicture.Location = new System.Drawing.Point(244, 80);
            this.processedPicture.Name = "processedPicture";
            this.processedPicture.Size = new System.Drawing.Size(226, 226);
            this.processedPicture.TabIndex = 1;
            this.processedPicture.TabStop = false;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 12);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(138, 32);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Open file...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PNG files|*.png";
            this.openFileDialog.ShowReadOnly = true;
            // 
            // processed2Picture
            // 
            this.processed2Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processed2Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.processed2Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processed2Picture.Location = new System.Drawing.Point(476, 80);
            this.processed2Picture.Name = "processed2Picture";
            this.processed2Picture.Size = new System.Drawing.Size(226, 226);
            this.processed2Picture.TabIndex = 3;
            this.processed2Picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brightness analysis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "+Hue analysis";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processed2Picture);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.processedPicture);
            this.Controls.Add(this.originalPicture);
            this.Name = "MainForm";
            this.Text = "Squares cleaner";
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed2Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPicture;
        private System.Windows.Forms.PictureBox processedPicture;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox processed2Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

