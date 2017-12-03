using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Models;
using ProductManager.Events;

namespace ProductManager.Views
{
    public interface IInventorySearchResults
    {
    }

    public partial class UCInventorySearchResults : UserControl, IInventorySearchResults
    {
        public UCInventorySearchResults()
        {
            InitializeComponent();
        }


        internal void DisplaySearchResults(InventorySearchResults inventorySearchResults)
        {
            lbTitleSearchMatches.Items.Clear();
            tlpImageSearchMatches.Controls.Clear();

            decimal itemCount = inventorySearchResults.InventoryItems.Count();

            for (var i=0; i < itemCount; i++)
            {
                var sku = inventorySearchResults.InventoryItems[i].SKU;
                var title = inventorySearchResults.InventoryItems[i].Title;

                lbTitleSearchMatches.Items.Add(title);

                var row = (int)Math.Floor(itemCount / 8);
                var col = (int)itemCount % 8;

                var pb = new PictureBox();
                pb.Name = sku;
                pb.Image = inventorySearchResults.InventoryItems[i].PrimaryPicture;
                pb.Size = new System.Drawing.Size(200, 200);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Click += new EventHandler(OnImageClick);

                tlpImageSearchMatches.Controls.Add(pb, col, row);
            }
        }

        private void lbTitleSearchMatches_MouseHover(object sender, EventArgs e)
        {
            Point point = lbTitleSearchMatches.PointToClient(Cursor.Position);
            int index = lbTitleSearchMatches.IndexFromPoint(point);
            if (index < 0) return;
            //Do any action with the item
            MessageBox.Show("MouseButtons hover triggered");
            lbTitleSearchMatches.GetItemRectangle(index).Inflate(3, 4);
        }

        private void OnImageClick(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            EventAggregator.Instance.Publish(new InventoryProductDetails { SKU = pb.Name });
        }

        private void lbTitleSearchMatches_SelectedValueChanged(object sender, EventArgs e)
        {
            var lb = (ListBox)sender;
            EventAggregator.Instance.Publish(new InventoryProductDetails { SKU = lb.SelectedItem.ToString() });
        }

    }
}
