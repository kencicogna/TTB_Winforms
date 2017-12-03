namespace ProductManager.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMainInventory = new System.Windows.Forms.TabPage();
            this.tabPageMainShipping = new System.Windows.Forms.TabPage();
            this.tabPageMainPickList = new System.Windows.Forms.TabPage();
            this.tabPageMainAdmin = new System.Windows.Forms.TabPage();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.tlpMainHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblMainHeaderStatus = new System.Windows.Forms.Label();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlStatusTextContainer = new System.Windows.Forms.Panel();
            this.tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.tlpMainHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlStatusTextContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControlMain.Location = new System.Drawing.Point(12, 135);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(957, 475);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabPageMainInventory
            // 
            this.tabPageMainInventory.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMainInventory.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainInventory.Name = "tabPageMainInventory";
            this.tabPageMainInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainInventory.Size = new System.Drawing.Size(949, 442);
            this.tabPageMainInventory.TabIndex = 0;
            this.tabPageMainInventory.Text = "Inventory";
            // 
            // tabPageMainShipping
            // 
            this.tabPageMainShipping.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainShipping.Name = "tabPageMainShipping";
            this.tabPageMainShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainShipping.Size = new System.Drawing.Size(949, 552);
            this.tabPageMainShipping.TabIndex = 1;
            this.tabPageMainShipping.Text = "Shipping";
            this.tabPageMainShipping.UseVisualStyleBackColor = true;
            // 
            // tabPageMainPickList
            // 
            this.tabPageMainPickList.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainPickList.Name = "tabPageMainPickList";
            this.tabPageMainPickList.Size = new System.Drawing.Size(949, 552);
            this.tabPageMainPickList.TabIndex = 2;
            this.tabPageMainPickList.Text = "PickList";
            this.tabPageMainPickList.UseVisualStyleBackColor = true;
            // 
            // tabPageMainAdmin
            // 
            this.tabPageMainAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainAdmin.Name = "tabPageMainAdmin";
            this.tabPageMainAdmin.Size = new System.Drawing.Size(949, 552);
            this.tabPageMainAdmin.TabIndex = 3;
            this.tabPageMainAdmin.Text = "Settings";
            this.tabPageMainAdmin.UseVisualStyleBackColor = true;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(0, 0);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(100, 100);
            this.pbAvatar.TabIndex = 1;
            this.pbAvatar.TabStop = false;
            this.toolTipMainForm.SetToolTip(this.pbAvatar, "Do you like my top hat?");
            // 
            // tlpMainHeader
            // 
            this.tlpMainHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.tlpMainHeader.ColumnCount = 3;
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMainHeader.Controls.Add(this.pbAvatar, 0, 0);
            this.tlpMainHeader.Controls.Add(this.panel1, 1, 0);
            this.tlpMainHeader.Location = new System.Drawing.Point(12, 12);
            this.tlpMainHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMainHeader.Name = "tlpMainHeader";
            this.tlpMainHeader.RowCount = 1;
            this.tlpMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMainHeader.Size = new System.Drawing.Size(957, 100);
            this.tlpMainHeader.TabIndex = 0;
            // 
            // lblMainHeaderStatus
            // 
            this.lblMainHeaderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainHeaderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeaderStatus.Location = new System.Drawing.Point(0, 0);
            this.lblMainHeaderStatus.MinimumSize = new System.Drawing.Size(360, 70);
            this.lblMainHeaderStatus.Name = "lblMainHeaderStatus";
            this.lblMainHeaderStatus.Size = new System.Drawing.Size(498, 88);
            this.lblMainHeaderStatus.TabIndex = 2;
            this.lblMainHeaderStatus.Text = "Hi. My name is Coonie, and Im here to assist you with all your Inventory. needs";
            this.lblMainHeaderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTipMainForm
            // 
            this.toolTipMainForm.AutoPopDelay = 5000;
            this.toolTipMainForm.InitialDelay = 500;
            this.toolTipMainForm.IsBalloon = true;
            this.toolTipMainForm.ReshowDelay = 100;
            this.toolTipMainForm.ShowAlways = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pnlStatusTextContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 100);
            this.panel1.TabIndex = 2;
            // 
            // pnlStatusTextContainer
            // 
            this.pnlStatusTextContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatusTextContainer.Controls.Add(this.lblMainHeaderStatus);
            this.pnlStatusTextContainer.Location = new System.Drawing.Point(62, 6);
            this.pnlStatusTextContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStatusTextContainer.Name = "pnlStatusTextContainer";
            this.pnlStatusTextContainer.Size = new System.Drawing.Size(498, 88);
            this.pnlStatusTextContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 667);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.tlpMainHeader);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.tlpMainHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlStatusTextContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMainPickList;
        private System.Windows.Forms.TabPage tabPageMainAdmin;
        private System.Windows.Forms.TabPage tabPageMainInventory;
        private System.Windows.Forms.TabPage tabPageMainShipping;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TableLayoutPanel tlpMainHeader;
        private System.Windows.Forms.Label lblMainHeaderStatus;
        private System.Windows.Forms.ToolTip toolTipMainForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlStatusTextContainer;
    }
}

