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

namespace ProductManager.Views.Inventory
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
            //cbTitleSearchMatches.Items.Clear();
            tlpImageSearchMatches.Controls.Clear();

            decimal itemCount = inventorySearchResults.InventoryItems.Count();

            for (var i=0; i < itemCount; i++)
            {
                var row = (int)Math.Floor(itemCount / 6);
                var col = (int)itemCount % 6;

                var pb = new PictureBox();
                pb.Name = inventorySearchResults.InventoryItems[i].SKU;
                pb.Image = inventorySearchResults.InventoryItems[i].PrimaryPicture;
                pb.Size = new System.Drawing.Size(175, 175);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Click += new EventHandler(OnImageClick);

                pb.Tag = inventorySearchResults.InventoryItems[i];

                tlpImageSearchMatches.Controls.Add(pb, col, row);
            }
        }

        private void OnImageClick(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            EventAggregator.Instance.Publish(new InventoryProductDetails { inventoryItem = (InventoryItem)pb.Tag });
        }

    }
}
