namespace ProductManager.Views.Inventory
{
    partial class UCInventoryView
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
            this.toolTipsInventory = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSeachBarContainer = new System.Windows.Forms.Panel();
            this.pnlSearchResultsContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // toolTipsInventory
            // 
            this.toolTipsInventory.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipsInventory.ToolTipTitle = "Searching";
            // 
            // pnlSeachBarContainer
            // 
            this.pnlSeachBarContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeachBarContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlSeachBarContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlSeachBarContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSeachBarContainer.Name = "pnlSeachBarContainer";
            this.pnlSeachBarContainer.Size = new System.Drawing.Size(900, 60);
            this.pnlSeachBarContainer.TabIndex = 0;
            // 
            // pnlSearchResultsContainer
            // 
            this.pnlSearchResultsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchResultsContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSearchResultsContainer.Location = new System.Drawing.Point(0, 65);
            this.pnlSearchResultsContainer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlSearchResultsContainer.Name = "pnlSearchResultsContainer";
            this.pnlSearchResultsContainer.Size = new System.Drawing.Size(900, 505);
            this.pnlSearchResultsContainer.TabIndex = 1;
            // 
            // UCInventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlSeachBarContainer);
            this.Controls.Add(this.pnlSearchResultsContainer);
            this.Name = "UCInventoryView";
            this.Size = new System.Drawing.Size(900, 565);
            this.Load += new System.EventHandler(this.UCInventoryView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipsInventory;
        private System.Windows.Forms.Panel pnlSeachBarContainer;
        private System.Windows.Forms.Panel pnlSearchResultsContainer;
    }
}
