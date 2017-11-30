namespace ProductManager.Views
{
    partial class UserControlInventory
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ucInventorySearchBar1 = new ProductManager.Views.UCInventorySearchBar();
            this.ucInventoryProductEditor1 = new ProductManager.Views.UCInventoryProductEditor();
            this.ucInventorySearchResults1 = new ProductManager.Views.UCInventorySearchResults();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Searching";
            // 
            // ucInventorySearchBar1
            // 
            this.ucInventorySearchBar1.Location = new System.Drawing.Point(3, 0);
            this.ucInventorySearchBar1.Name = "ucInventorySearchBar1";
            this.ucInventorySearchBar1.Size = new System.Drawing.Size(753, 80);
            this.ucInventorySearchBar1.TabIndex = 4;
            // 
            // ucInventoryProductEditor1
            // 
            this.ucInventoryProductEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInventoryProductEditor1.Location = new System.Drawing.Point(3, 418);
            this.ucInventoryProductEditor1.Name = "ucInventoryProductEditor1";
            this.ucInventoryProductEditor1.Size = new System.Drawing.Size(753, 180);
            this.ucInventoryProductEditor1.TabIndex = 5;
            // 
            // ucInventorySearchResults1
            // 
            this.ucInventorySearchResults1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInventorySearchResults1.Location = new System.Drawing.Point(3, 86);
            this.ucInventorySearchResults1.Name = "ucInventorySearchResults1";
            this.ucInventorySearchResults1.Size = new System.Drawing.Size(753, 295);
            this.ucInventorySearchResults1.TabIndex = 6;
            // 
            // UserControlInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ucInventorySearchResults1);
            this.Controls.Add(this.ucInventoryProductEditor1);
            this.Controls.Add(this.ucInventorySearchBar1);
            this.Name = "UserControlInventory";
            this.Size = new System.Drawing.Size(759, 601);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private UCInventorySearchBar ucInventorySearchBar1;
        private UCInventoryProductEditor ucInventoryProductEditor1;
        private UCInventorySearchResults ucInventorySearchResults1;
    }
}
