﻿namespace ProductManager.Views
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
            this.tlpImageSearchMatches = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearchResults = new System.Windows.Forms.Panel();
            this.pnlSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpImageSearchMatches
            // 
            this.tlpImageSearchMatches.BackColor = System.Drawing.SystemColors.Control;
            this.tlpImageSearchMatches.ColumnCount = 6;
            this.tlpImageSearchMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageSearchMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageSearchMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageSearchMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageSearchMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageSearchMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageSearchMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpImageSearchMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpImageSearchMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImageSearchMatches.Location = new System.Drawing.Point(0, 0);
            this.tlpImageSearchMatches.Name = "tlpImageSearchMatches";
            this.tlpImageSearchMatches.RowCount = 3;
            this.tlpImageSearchMatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImageSearchMatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImageSearchMatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImageSearchMatches.Size = new System.Drawing.Size(799, 530);
            this.tlpImageSearchMatches.TabIndex = 2;
            // 
            // pnlSearchResults
            // 
            this.pnlSearchResults.Controls.Add(this.tlpImageSearchMatches);
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

        private System.Windows.Forms.TableLayoutPanel tlpImageSearchMatches;
        private System.Windows.Forms.Panel pnlSearchResults;
    }
}