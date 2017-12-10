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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpMenuStrip = new System.Windows.Forms.TableLayoutPanel();
            this.pbMenuSettings = new System.Windows.Forms.PictureBox();
            this.pbMenuPickList = new System.Windows.Forms.PictureBox();
            this.pbMenuShipping = new System.Windows.Forms.PictureBox();
            this.pbMenuInventory = new System.Windows.Forms.PictureBox();
            this.pnlStatusTextContainer = new System.Windows.Forms.Panel();
            this.lblMainHeaderStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.tlpMainHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuPickList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuShipping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuInventory)).BeginInit();
            this.pnlStatusTextContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageMainInventory);
            this.tabControlMain.Controls.Add(this.tabPageMainShipping);
            this.tabControlMain.Controls.Add(this.tabPageMainPickList);
            this.tabControlMain.Controls.Add(this.tabPageMainAdmin);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(15, 135);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1117, 475);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabPageMainInventory
            // 
            this.tabPageMainInventory.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMainInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMainInventory.ImageIndex = 0;
            this.tabPageMainInventory.Location = new System.Drawing.Point(4, 4);
            this.tabPageMainInventory.Name = "tabPageMainInventory";
            this.tabPageMainInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainInventory.Size = new System.Drawing.Size(1109, 442);
            this.tabPageMainInventory.TabIndex = 0;
            this.tabPageMainInventory.Text = "Inventory";
            // 
            // tabPageMainShipping
            // 
            this.tabPageMainShipping.ImageIndex = 2;
            this.tabPageMainShipping.Location = new System.Drawing.Point(4, 4);
            this.tabPageMainShipping.Name = "tabPageMainShipping";
            this.tabPageMainShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainShipping.Size = new System.Drawing.Size(1126, 442);
            this.tabPageMainShipping.TabIndex = 1;
            this.tabPageMainShipping.Text = "Shipping";
            this.tabPageMainShipping.UseVisualStyleBackColor = true;
            // 
            // tabPageMainPickList
            // 
            this.tabPageMainPickList.ImageIndex = 1;
            this.tabPageMainPickList.Location = new System.Drawing.Point(4, 4);
            this.tabPageMainPickList.Name = "tabPageMainPickList";
            this.tabPageMainPickList.Size = new System.Drawing.Size(1126, 442);
            this.tabPageMainPickList.TabIndex = 2;
            this.tabPageMainPickList.Text = "PickList";
            this.tabPageMainPickList.UseVisualStyleBackColor = true;
            // 
            // tabPageMainAdmin
            // 
            this.tabPageMainAdmin.ImageIndex = 3;
            this.tabPageMainAdmin.Location = new System.Drawing.Point(4, 4);
            this.tabPageMainAdmin.Name = "tabPageMainAdmin";
            this.tabPageMainAdmin.Size = new System.Drawing.Size(1126, 442);
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
            this.tlpMainHeader.BackColor = System.Drawing.Color.Transparent;
            this.tlpMainHeader.ColumnCount = 3;
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMainHeader.Controls.Add(this.pbAvatar, 0, 0);
            this.tlpMainHeader.Controls.Add(this.panel1, 1, 0);
            this.tlpMainHeader.Controls.Add(this.pictureBox1, 2, 0);
            this.tlpMainHeader.Location = new System.Drawing.Point(15, 12);
            this.tlpMainHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMainHeader.Name = "tlpMainHeader";
            this.tlpMainHeader.RowCount = 1;
            this.tlpMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMainHeader.Size = new System.Drawing.Size(1117, 100);
            this.tlpMainHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.tlpMenuStrip);
            this.panel1.Controls.Add(this.pnlStatusTextContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 100);
            this.panel1.TabIndex = 2;
            // 
            // tlpMenuStrip
            // 
            this.tlpMenuStrip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpMenuStrip.ColumnCount = 4;
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMenuStrip.Controls.Add(this.pbMenuSettings, 3, 0);
            this.tlpMenuStrip.Controls.Add(this.pbMenuPickList, 2, 0);
            this.tlpMenuStrip.Controls.Add(this.pbMenuInventory, 0, 0);
            this.tlpMenuStrip.Controls.Add(this.pbMenuShipping, 1, 0);
            this.tlpMenuStrip.Location = new System.Drawing.Point(597, 0);
            this.tlpMenuStrip.Name = "tlpMenuStrip";
            this.tlpMenuStrip.RowCount = 1;
            this.tlpMenuStrip.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenuStrip.Size = new System.Drawing.Size(320, 100);
            this.tlpMenuStrip.TabIndex = 3;
            // 
            // pbMenuSettings
            // 
            this.pbMenuSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMenuSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuSettings.Image")));
            this.pbMenuSettings.Location = new System.Drawing.Point(243, 3);
            this.pbMenuSettings.Name = "pbMenuSettings";
            this.pbMenuSettings.Size = new System.Drawing.Size(74, 94);
            this.pbMenuSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenuSettings.TabIndex = 3;
            this.pbMenuSettings.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMenuSettings, "Settings");
            this.pbMenuSettings.Click += new System.EventHandler(this.pbMenuSettings_Click);
            this.pbMenuSettings.MouseEnter += new System.EventHandler(this.pbMenuSettings_MouseEnter);
            this.pbMenuSettings.MouseLeave += new System.EventHandler(this.pbMenuSettings_MouseLeave);
            // 
            // pbMenuPickList
            // 
            this.pbMenuPickList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMenuPickList.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuPickList.Image")));
            this.pbMenuPickList.Location = new System.Drawing.Point(163, 3);
            this.pbMenuPickList.Name = "pbMenuPickList";
            this.pbMenuPickList.Size = new System.Drawing.Size(74, 94);
            this.pbMenuPickList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenuPickList.TabIndex = 2;
            this.pbMenuPickList.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMenuPickList, "Picklist");
            this.pbMenuPickList.Click += new System.EventHandler(this.pbMenuPickList_Click);
            this.pbMenuPickList.MouseEnter += new System.EventHandler(this.pbMenuPickList_MouseEnter);
            this.pbMenuPickList.MouseLeave += new System.EventHandler(this.pbMenuPickList_MouseLeave);
            // 
            // pbMenuShipping
            // 
            this.pbMenuShipping.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMenuShipping.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuShipping.Image")));
            this.pbMenuShipping.Location = new System.Drawing.Point(83, 3);
            this.pbMenuShipping.Name = "pbMenuShipping";
            this.pbMenuShipping.Size = new System.Drawing.Size(74, 94);
            this.pbMenuShipping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenuShipping.TabIndex = 1;
            this.pbMenuShipping.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMenuShipping, "Shipping");
            this.pbMenuShipping.Click += new System.EventHandler(this.pbMenuShipping_Click);
            this.pbMenuShipping.MouseEnter += new System.EventHandler(this.pbMenuShipping_MouseEnter);
            this.pbMenuShipping.MouseLeave += new System.EventHandler(this.pbMenuShipping_MouseLeave);
            // 
            // pbMenuInventory
            // 
            this.pbMenuInventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMenuInventory.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuInventory.Image")));
            this.pbMenuInventory.Location = new System.Drawing.Point(3, 3);
            this.pbMenuInventory.Name = "pbMenuInventory";
            this.pbMenuInventory.Size = new System.Drawing.Size(74, 94);
            this.pbMenuInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenuInventory.TabIndex = 0;
            this.pbMenuInventory.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMenuInventory, "Inventory");
            this.pbMenuInventory.Click += new System.EventHandler(this.pbMenuInventory_Click);
            this.pbMenuInventory.MouseEnter += new System.EventHandler(this.pbMenuInventory_MouseEnter);
            this.pbMenuInventory.MouseLeave += new System.EventHandler(this.pbMenuInventory_MouseLeave);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1017, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // toolTipMainForm
            // 
            this.toolTipMainForm.AutomaticDelay = 100;
            this.toolTipMainForm.AutoPopDelay = 1000;
            this.toolTipMainForm.InitialDelay = 100;
            this.toolTipMainForm.IsBalloon = true;
            this.toolTipMainForm.ReshowDelay = 10;
            this.toolTipMainForm.ShowAlways = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 1000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 667);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.tlpMainHeader);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "The Teaching Toy Box";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.tlpMainHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlpMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuPickList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuShipping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuInventory)).EndInit();
            this.pnlStatusTextContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpMenuStrip;
        private System.Windows.Forms.PictureBox pbMenuInventory;
        private System.Windows.Forms.PictureBox pbMenuShipping;
        private System.Windows.Forms.PictureBox pbMenuPickList;
        private System.Windows.Forms.PictureBox pbMenuSettings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

