namespace ProductManager.Views.Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInventorySearchBar));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnShowSearchResultsView = new System.Windows.Forms.Button();
            this.btnShowProductView = new System.Windows.Forms.Button();
            this.btnLockColumns = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbLockColumns = new System.Windows.Forms.PictureBox();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockColumns)).BeginInit();
            this.pnlSearchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = true;
            this.tbSearch.AcceptsTab = true;
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbSearch.Location = new System.Drawing.Point(3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(694, 23);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.Text = "Search SKU, UPC, and Title";
            this.toolTip1.SetToolTip(this.tbSearch, "Searches SKU, UPC, and Title");
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
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
            // btnLockColumns
            // 
            this.btnLockColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLockColumns.Location = new System.Drawing.Point(392, 32);
            this.btnLockColumns.Name = "btnLockColumns";
            this.btnLockColumns.Size = new System.Drawing.Size(100, 25);
            this.btnLockColumns.TabIndex = 5;
            this.btnLockColumns.Text = "Lock Columns";
            this.btnLockColumns.UseVisualStyleBackColor = true;
            this.btnLockColumns.Click += new System.EventHandler(this.btnLockColumns_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(597, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbLockColumns
            // 
            this.pbLockColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLockColumns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLockColumns.BackgroundImage")));
            this.pbLockColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLockColumns.Location = new System.Drawing.Point(364, 32);
            this.pbLockColumns.Name = "pbLockColumns";
            this.pbLockColumns.Size = new System.Drawing.Size(25, 25);
            this.pbLockColumns.TabIndex = 7;
            this.pbLockColumns.TabStop = false;
            this.pbLockColumns.Tag = "Unlocked";
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.Controls.Add(this.btnUndo);
            this.pnlSearchBar.Controls.Add(this.btnSave);
            this.pnlSearchBar.Controls.Add(this.pbLockColumns);
            this.pnlSearchBar.Controls.Add(this.tbSearch);
            this.pnlSearchBar.Controls.Add(this.btnShowSearchResultsView);
            this.pnlSearchBar.Controls.Add(this.btnLockColumns);
            this.pnlSearchBar.Controls.Add(this.btnShowProductView);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(700, 60);
            this.pnlSearchBar.TabIndex = 8;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Location = new System.Drawing.Point(495, 32);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 25);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Undo Changes";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // UCInventorySearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlSearchBar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCInventorySearchBar";
            this.Size = new System.Drawing.Size(700, 60);
            this.Load += new System.EventHandler(this.UCInventorySearchBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLockColumns)).EndInit();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnShowSearchResultsView;
        private System.Windows.Forms.Button btnShowProductView;
        private System.Windows.Forms.Button btnLockColumns;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbLockColumns;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Button btnUndo;
    }
}
