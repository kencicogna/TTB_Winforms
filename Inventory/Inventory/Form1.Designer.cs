namespace Inventory
{
    partial class Form1
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
            System.Windows.Forms.Label lblTitleSearch;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tbTitleSearch = new System.Windows.Forms.TextBox();
            this.dsTTB = new Inventory.dsTTB();
            this.dsTTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Inventory.dsTTBTableAdapters.InventoryTableAdapter();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            lblTitleSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleSearch
            // 
            lblTitleSearch.AutoSize = true;
            lblTitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitleSearch.Location = new System.Drawing.Point(53, 45);
            lblTitleSearch.Name = "lblTitleSearch";
            lblTitleSearch.Size = new System.Drawing.Size(97, 20);
            lblTitleSearch.TabIndex = 0;
            lblTitleSearch.Text = "Title Search:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvInventory);
            this.panel1.Location = new System.Drawing.Point(72, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 446);
            this.panel1.TabIndex = 2;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AutoGenerateColumns = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skuDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.variationDataGridViewTextBoxColumn,
            this.binrackDataGridViewTextBoxColumn});
            this.dgvInventory.DataSource = this.inventoryBindingSource;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(0, 0);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(946, 446);
            this.dgvInventory.TabIndex = 0;
            // 
            // tbTitleSearch
            // 
            this.tbTitleSearch.Location = new System.Drawing.Point(156, 45);
            this.tbTitleSearch.Name = "tbTitleSearch";
            this.tbTitleSearch.Size = new System.Drawing.Size(524, 20);
            this.tbTitleSearch.TabIndex = 3;
            this.tbTitleSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTitleSearch_KeyUp);
            // 
            // dsTTB
            // 
            this.dsTTB.DataSetName = "dsTTB";
            this.dsTTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTTBBindingSource
            // 
            this.dsTTBBindingSource.DataSource = this.dsTTB;
            this.dsTTBBindingSource.Position = 0;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.dsTTBBindingSource;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "sku";
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // variationDataGridViewTextBoxColumn
            // 
            this.variationDataGridViewTextBoxColumn.DataPropertyName = "variation";
            this.variationDataGridViewTextBoxColumn.HeaderText = "variation";
            this.variationDataGridViewTextBoxColumn.Name = "variationDataGridViewTextBoxColumn";
            this.variationDataGridViewTextBoxColumn.Width = 200;
            // 
            // binrackDataGridViewTextBoxColumn
            // 
            this.binrackDataGridViewTextBoxColumn.DataPropertyName = "binrack";
            this.binrackDataGridViewTextBoxColumn.HeaderText = "binrack";
            this.binrackDataGridViewTextBoxColumn.Name = "binrackDataGridViewTextBoxColumn";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(942, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(861, 110);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 643);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTitleSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(lblTitleSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox tbTitleSearch;
        private System.Windows.Forms.BindingSource dsTTBBindingSource;
        private dsTTB dsTTB;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private dsTTBTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn binrackDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
    }
}

