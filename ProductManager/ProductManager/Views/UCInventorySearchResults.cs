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

            // Initialize Image Boxes
            //var missingImage = Image.FromFile(@"C:\Users\Ken\Documents\GitHub\TTB_Winforms\ProductManager\ProductManager\Images\missing_128x128.jpg");
            //var pictureBoxList = new List<PictureBox>();

            //for (int row = 0; row < 2; row++)
            //{
            //    for (int col = 0; col < 8; col++)
            //    {
            //        var pb = new PictureBox();
            //        pb.Image = missingImage;
            //        pb.Size = new System.Drawing.Size(156, 156);
            //        pb.Padding = new Padding(4, 4, 4, 4);
            //        pb.Click += new EventHandler(OnImageClick);

            //        //tlpImageSearchMatches.Controls.Add(pb, col, row);
            //    }
            //}

        }

        private void OnImageClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        internal void DisplaySearchResults(InventorySearchResults inventorySearchResults)
        {
            lbTitleSearchMatches.Items.Clear();
            tlpImageSearchMatches.Controls.Clear();

            decimal itemCount = inventorySearchResults.InventoryItems.Count();

            for (var i=0; i < itemCount; i++)
            {
                lbTitleSearchMatches.Items.Add(inventorySearchResults.InventoryItems[i].Title);

                var row = (int)Math.Floor(itemCount / 8);
                var col = (int)itemCount % 8;

                var pb = new PictureBox();
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

    }
}
