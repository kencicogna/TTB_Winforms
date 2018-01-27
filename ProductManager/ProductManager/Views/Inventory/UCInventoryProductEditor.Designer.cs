namespace ProductManager.Views.Inventory
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
            this.pnlProductEditor = new System.Windows.Forms.Panel();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.pnlProductEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductEditor
            // 
            this.pnlProductEditor.Controls.Add(this.dgvProductDetails);
            this.pnlProductEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlProductEditor.Name = "pnlProductEditor";
            this.pnlProductEditor.Size = new System.Drawing.Size(713, 510);
            this.pnlProductEditor.TabIndex = 1;
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.Size = new System.Drawing.Size(713, 510);
            this.dgvProductDetails.TabIndex = 0;
            this.dgvProductDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellMouseEnter);
            this.dgvProductDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellMouseLeave);
            this.dgvProductDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellValueChanged);
            // 
            // UCInventoryProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProductEditor);
            this.Name = "UCInventoryProductEditor";
            this.Size = new System.Drawing.Size(713, 510);
            this.pnlProductEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlProductEditor;
        private System.Windows.Forms.DataGridView dgvProductDetails;
    }
}
