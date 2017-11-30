using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager.Views
{
    public interface IInventorySearchResults
    {
        void ShowView();
        void HideView();
    }

    public partial class UCInventorySearchResults : UserControl, IInventorySearchResults
    {
        public UCInventorySearchResults()
        {
            InitializeComponent();

            // Initialize Image Boxes
            var missingImage = Image.FromFile(@"C:\Users\Ken\Documents\GitHub\TTB_Winforms\ProductManager\ProductManager\Images\missing_128x128.jpg");
            var pictureBoxList = new List<PictureBox>();

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    var pb = new PictureBox();
                    pb.Image = missingImage;
                    pb.Size = new System.Drawing.Size(128, 128);

                    tlpImageMatches.Controls.Add(pb, col, row);
                }
            }

        }

        public void ShowView()
        {
            pnlSearchResults.Show();
        }

        public void HideView()
        {
            pnlSearchResults.Hide();
        }
    }
}
