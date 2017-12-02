namespace ProductManager.Views
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
            this.ucInventorySearchBar = new ProductManager.Views.UCInventorySearchBar();
            this.pnlSearchResultsContainer = new System.Windows.Forms.Panel();
            this.ucInventorySearchResults = new ProductManager.Views.UCInventorySearchResults();
            this.pnlProductEditorContainer = new System.Windows.Forms.Panel();
            this.ucInventoryProductEditor = new ProductManager.Views.UCInventoryProductEditor();
            this.pnlSeachBarContainer.SuspendLayout();
            this.pnlSearchResultsContainer.SuspendLayout();
            this.pnlProductEditorContainer.SuspendLayout();
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
            this.pnlSeachBarContainer.Controls.Add(this.ucInventorySearchBar);
            this.pnlSeachBarContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlSeachBarContainer.Name = "pnlSeachBarContainer";
            this.pnlSeachBarContainer.Size = new System.Drawing.Size(893, 87);
            this.pnlSeachBarContainer.TabIndex = 0;
            // 
            // ucInventorySearchBar
            // 
            this.ucInventorySearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInventorySearchBar.Location = new System.Drawing.Point(0, 0);
            this.ucInventorySearchBar.Name = "ucInventorySearchBar";
            this.ucInventorySearchBar.Size = new System.Drawing.Size(893, 87);
            this.ucInventorySearchBar.TabIndex = 0;
            // 
            // pnlSearchResultsContainer
            // 
            this.pnlSearchResultsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchResultsContainer.Controls.Add(this.ucInventorySearchResults);
            this.pnlSearchResultsContainer.Location = new System.Drawing.Point(3, 99);
            this.pnlSearchResultsContainer.Name = "pnlSearchResultsContainer";
            this.pnlSearchResultsContainer.Size = new System.Drawing.Size(896, 473);
            this.pnlSearchResultsContainer.TabIndex = 1;
            // 
            // ucInventorySearchResults
            // 
            this.ucInventorySearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInventorySearchResults.Location = new System.Drawing.Point(0, 0);
            this.ucInventorySearchResults.Margin = new System.Windows.Forms.Padding(0);
            this.ucInventorySearchResults.Name = "ucInventorySearchResults";
            this.ucInventorySearchResults.Size = new System.Drawing.Size(896, 473);
            this.ucInventorySearchResults.TabIndex = 1;
            // 
            // pnlProductEditorContainer
            // 
            this.pnlProductEditorContainer.Controls.Add(this.ucInventoryProductEditor);
            this.pnlProductEditorContainer.Location = new System.Drawing.Point(3, 96);
            this.pnlProductEditorContainer.Name = "pnlProductEditorContainer";
            this.pnlProductEditorContainer.Size = new System.Drawing.Size(893, 476);
            this.pnlProductEditorContainer.TabIndex = 2;
            // 
            // ucInventoryProductEditor
            // 
            this.ucInventoryProductEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInventoryProductEditor.Location = new System.Drawing.Point(0, 0);
            this.ucInventoryProductEditor.Name = "ucInventoryProductEditor";
            this.ucInventoryProductEditor.Size = new System.Drawing.Size(893, 476);
            this.ucInventoryProductEditor.TabIndex = 0;
            // 
            // UCInventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlSeachBarContainer);
            this.Controls.Add(this.pnlSearchResultsContainer);
            this.Controls.Add(this.pnlProductEditorContainer);
            this.Name = "UCInventoryView";
            this.Size = new System.Drawing.Size(902, 575);
            this.pnlSeachBarContainer.ResumeLayout(false);
            this.pnlSearchResultsContainer.ResumeLayout(false);
            this.pnlProductEditorContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipsInventory;
        private System.Windows.Forms.Panel pnlSeachBarContainer;
        private System.Windows.Forms.Panel pnlSearchResultsContainer;
        private UCInventorySearchBar ucInventorySearchBar;
        private UCInventorySearchResults ucInventorySearchResults;
        private UCInventoryProductEditor ucInventoryProductEditor;
        private System.Windows.Forms.Panel pnlProductEditorContainer;
    }
}
