namespace ProductManager.Views
{
    partial class UCInventorySearchResults
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
            this.tlpImageMatches = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlSearchResults = new System.Windows.Forms.Panel();
            this.pnlSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpImageMatches
            // 
            this.tlpImageMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpImageMatches.ColumnCount = 8;
            this.tlpImageMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageMatches.Location = new System.Drawing.Point(4, 97);
            this.tlpImageMatches.Name = "tlpImageMatches";
            this.tlpImageMatches.RowCount = 2;
            this.tlpImageMatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImageMatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImageMatches.Size = new System.Drawing.Size(792, 430);
            this.tlpImageMatches.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6",
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(793, 69);
            this.listBox1.TabIndex = 1;
            // 
            // pnlSearchResults
            // 
            this.pnlSearchResults.Controls.Add(this.tlpImageMatches);
            this.pnlSearchResults.Controls.Add(this.listBox1);
            this.pnlSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchResults.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchResults.Name = "pnlSearchResults";
            this.pnlSearchResults.Size = new System.Drawing.Size(799, 530);
            this.pnlSearchResults.TabIndex = 4;
            // 
            // UCInventorySearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSearchResults);
            this.Name = "UCInventorySearchResults";
            this.Size = new System.Drawing.Size(799, 530);
            this.pnlSearchResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpImageMatches;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnlSearchResults;
    }
}
