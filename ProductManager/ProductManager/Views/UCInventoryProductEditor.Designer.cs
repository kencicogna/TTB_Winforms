namespace ProductManager.Views
{
    partial class UCInventoryProductEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProductEditor = new System.Windows.Forms.Panel();
            this.pnlProductEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is the product editor";
            // 
            // pnlProductEditor
            // 
            this.pnlProductEditor.Controls.Add(this.label1);
            this.pnlProductEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlProductEditor.Name = "pnlProductEditor";
            this.pnlProductEditor.Size = new System.Drawing.Size(713, 510);
            this.pnlProductEditor.TabIndex = 1;
            // 
            // UCInventoryProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProductEditor);
            this.Name = "UCInventoryProductEditor";
            this.Size = new System.Drawing.Size(713, 510);
            this.pnlProductEditor.ResumeLayout(false);
            this.pnlProductEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProductEditor;
    }
}
