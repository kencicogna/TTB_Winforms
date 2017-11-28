using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        DataView dvInventoryView;
        dsTTB.InventoryDataTable dtInventoryTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTTB.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.dsTTB.Inventory);

            //Populates the DataSet using a helper method
            dtInventoryTable = (dsTTB.InventoryDataTable)dsTTB.Tables["Inventory"];
            
            //Creates a DataView from our table's default view
            dvInventoryView = dtInventoryTable.DefaultView;

            //Assigns the DataView to the grid
            dgvInventory.DataSource = dvInventoryView;
        }

        private void tbTitleSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string outputInfo = "";
            string[] keyWords = tbTitleSearch.Text.Split(' ');

            foreach (string word in keyWords)
            {
                if (outputInfo.Length == 0)
                {
                    outputInfo = "(Title LIKE '%" + word + "%' OR Variation LIKE '%" + word + "%')";
                }
                else
                {
                    outputInfo += " AND (Title LIKE '%" + word + "%' OR Variation LIKE '%" + word + "%')";
                }
            }

            //Applies the filter to the DataView
            dvInventoryView.RowFilter = outputInfo;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dsTTBBindingSource.EndEdit();
                this.inventoryTableAdapter.Update(dtInventoryTable);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }
    }
}
