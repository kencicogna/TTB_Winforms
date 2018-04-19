namespace ProductManager
{
    partial class formSplashScreen
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
            this.lblSplashScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSplashScreen
            // 
            this.lblSplashScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSplashScreen.AutoSize = true;
            this.lblSplashScreen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSplashScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashScreen.Location = new System.Drawing.Point(66, 72);
            this.lblSplashScreen.Name = "lblSplashScreen";
            this.lblSplashScreen.Size = new System.Drawing.Size(159, 25);
            this.lblSplashScreen.TabIndex = 0;
            this.lblSplashScreen.Text = "Product Saved!";
            this.lblSplashScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(288, 178);
            this.Controls.Add(this.lblSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplashScreen;
    }
}