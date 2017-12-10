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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnShowSearchResultsView = new System.Windows.Forms.Button();
            this.btnShowProductView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = true;
            this.tbSearch.AcceptsTab = true;
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(844, 23);
            this.tbSearch.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbSearch, "Searches SKU, UPC, and Title");
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btnShowSearchResultsView
            // 
            this.btnShowSearchResultsView.Location = new System.Drawing.Point(3, 32);
            this.btnShowSearchResultsView.Name = "btnShowSearchResultsView";
            this.btnShowSearchResultsView.Size = new System.Drawing.Size(80, 25);
            this.btnShowSearchResultsView.TabIndex = 3;
            this.btnShowSearchResultsView.Text = "Results View";
            this.btnShowSearchResultsView.UseVisualStyleBackColor = true;
            this.btnShowSearchResultsView.Click += new System.EventHandler(this.btnShowSearchResultsView_Click);
            // 
            // btnShowProductView
            // 
            this.btnShowProductView.Location = new System.Drawing.Point(89, 32);
            this.btnShowProductView.Name = "btnShowProductView";
            this.btnShowProductView.Size = new System.Drawing.Size(80, 25);
            this.btnShowProductView.TabIndex = 4;
            this.btnShowProductView.Text = "Product View";
            this.btnShowProductView.UseVisualStyleBackColor = true;
            this.btnShowProductView.Click += new System.EventHandler(this.btnShowProductView_Click);
            // 
            // UCInventorySearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowProductView);
            this.Controls.Add(this.btnShowSearchResultsView);
            this.Controls.Add(this.tbSearch);
            this.Name = "UCInventorySearchBar";
            this.Size = new System.Drawing.Size(861, 62);
            this.Load += new System.EventHandler(this.UCInventorySearchBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnShowSearchResultsView;
        private System.Windows.Forms.Button btnShowProductView;
    }
}
