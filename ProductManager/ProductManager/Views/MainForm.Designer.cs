﻿namespace ProductManager.Views
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainHeader = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMainInventory = new System.Windows.Forms.TabPage();
            this.userControlInventory1 = new ProductManager.Views.UserControlInventory();
            this.tabPageMainShipping = new System.Windows.Forms.TabPage();
            this.tabPageMainPickList = new System.Windows.Forms.TabPage();
            this.tabPageMainAdmin = new System.Windows.Forms.TabPage();
            this.pnlMainHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMainInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainHeader
            // 
            this.pnlMainHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMainHeader.Controls.Add(this.lblMainTitle);
            this.pnlMainHeader.Location = new System.Drawing.Point(12, 13);
            this.pnlMainHeader.Name = "pnlMainHeader";
            this.pnlMainHeader.Size = new System.Drawing.Size(1000, 51);
            this.pnlMainHeader.TabIndex = 0;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(351, 7);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(338, 37);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "The Teaching Toy Box";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageMainInventory);
            this.tabControlMain.Controls.Add(this.tabPageMainShipping);
            this.tabControlMain.Controls.Add(this.tabPageMainPickList);
            this.tabControlMain.Controls.Add(this.tabPageMainAdmin);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 70);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1004, 584);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageMainInventory
            // 
            this.tabPageMainInventory.Controls.Add(this.userControlInventory1);
            this.tabPageMainInventory.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainInventory.Name = "tabPageMainInventory";
            this.tabPageMainInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainInventory.Size = new System.Drawing.Size(996, 551);
            this.tabPageMainInventory.TabIndex = 0;
            this.tabPageMainInventory.Text = "Inventory";
            this.tabPageMainInventory.UseVisualStyleBackColor = true;
            // 
            // userControlInventory1
            // 
            this.userControlInventory1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlInventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlInventory1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlInventory1.Location = new System.Drawing.Point(3, 3);
            this.userControlInventory1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlInventory1.Name = "userControlInventory1";
            this.userControlInventory1.Size = new System.Drawing.Size(990, 545);
            this.userControlInventory1.TabIndex = 0;
            // 
            // tabPageMainShipping
            // 
            this.tabPageMainShipping.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainShipping.Name = "tabPageMainShipping";
            this.tabPageMainShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainShipping.Size = new System.Drawing.Size(996, 551);
            this.tabPageMainShipping.TabIndex = 1;
            this.tabPageMainShipping.Text = "Shipping";
            this.tabPageMainShipping.UseVisualStyleBackColor = true;
            // 
            // tabPageMainPickList
            // 
            this.tabPageMainPickList.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainPickList.Name = "tabPageMainPickList";
            this.tabPageMainPickList.Size = new System.Drawing.Size(996, 551);
            this.tabPageMainPickList.TabIndex = 2;
            this.tabPageMainPickList.Text = "PickList";
            this.tabPageMainPickList.UseVisualStyleBackColor = true;
            // 
            // tabPageMainAdmin
            // 
            this.tabPageMainAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainAdmin.Name = "tabPageMainAdmin";
            this.tabPageMainAdmin.Size = new System.Drawing.Size(996, 551);
            this.tabPageMainAdmin.TabIndex = 3;
            this.tabPageMainAdmin.Text = "Settings";
            this.tabPageMainAdmin.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 666);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlMainHeader);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.pnlMainHeader.ResumeLayout(false);
            this.pnlMainHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMainInventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainHeader;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMainInventory;
        private System.Windows.Forms.TabPage tabPageMainShipping;
        private System.Windows.Forms.TabPage tabPageMainPickList;
        private System.Windows.Forms.TabPage tabPageMainAdmin;
        private UserControlInventory userControlInventory1;
    }
}

