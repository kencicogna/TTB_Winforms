namespace ProductManager.Views
{
    partial class UCInventorySearchBar
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnShowProductView = new System.Windows.Forms.Button();
            this.btnShowSearchResultsView = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.gbSearch.Controls.Add(this.btnShowProductView);
            this.gbSearch.Controls.Add(this.btnShowSearchResultsView);
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(861, 92);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // btnShowProductView
            // 
            this.btnShowProductView.Location = new System.Drawing.Point(98, 45);
            this.btnShowProductView.Name = "btnShowProductView";
            this.btnShowProductView.Size = new System.Drawing.Size(80, 25);
            this.btnShowProductView.TabIndex = 4;
            this.btnShowProductView.Text = "Product View";
            this.btnShowProductView.UseVisualStyleBackColor = true;
            this.btnShowProductView.Click += new System.EventHandler(this.btnShowProductView_Click);
            // 
            // btnShowSearchResultsView
            // 
            this.btnShowSearchResultsView.Location = new System.Drawing.Point(11, 45);
            this.btnShowSearchResultsView.Name = "btnShowSearchResultsView";
            this.btnShowSearchResultsView.Size = new System.Drawing.Size(80, 25);
            this.btnShowSearchResultsView.TabIndex = 3;
            this.btnShowSearchResultsView.Text = "Results View";
            this.btnShowSearchResultsView.UseVisualStyleBackColor = true;
            this.btnShowSearchResultsView.Click += new System.EventHandler(this.btnShowSearchResultsView_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = true;
            this.tbSearch.AcceptsTab = true;
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(11, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(844, 20);
            this.tbSearch.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbSearch, "Searches SKU, UPC, and Title");
            // 
            // UCInventorySearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSearch);
            this.Name = "UCInventorySearchBar";
            this.Size = new System.Drawing.Size(861, 92);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnShowProductView;
        private System.Windows.Forms.Button btnShowSearchResultsView;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
