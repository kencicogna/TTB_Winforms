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
    public partial class UserControlInventory : UserControl
    {
        public UserControlInventory()
        {
            InitializeComponent();
            //var pb1 = new PictureBox();
            //pb1.Image = i1;
            //pb1.Size = new System.Drawing.Size(128, 128);

            //var pb2 = new PictureBox();
            //pb2.Image = i1;
            //pb2.Size = new System.Drawing.Size(128, 128);

            // Initialize Image Boxes
            var missingImage = Image.FromFile(@"C:\Users\Ken\Documents\GitHub\TTB_Winforms\ProductManager\ProductManager\Images\missing_128x128.jpg");
            var pictureBoxList = new List<PictureBox>();
            int idx;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    //idx = (row*8) + col;
                    var pb = new PictureBox();
                    pb.Image = missingImage;
                    pb.Size = new System.Drawing.Size(128, 128);

                    //pictureBoxList.Add(pb);
                    tlpImageMatches.Controls.Add(pb, col, row);
                }
            }


            //tlpImageMatches.Controls.Add(pb1, 0, 0);
            //tlpImageMatches.Controls.Add(pb1, 1, 0);
            //tlpImageMatches.Controls.Add(pb2, 2, 0);
            //tlpImageMatches.Controls.Add(pb1, 3, 0);
            //tlpImageMatches.Controls.Add(pb1, 4, 0);
            //tlpImageMatches.Controls.Add(pb1, 5, 0);
            //tlpImageMatches.Controls.Add(pb1, 6, 0);
            //tlpImageMatches.Controls.Add(pb1, 7, 0);
            //tlpImageMatches.Controls.Add(pb1, 0, 1);
            //tlpImageMatches.Controls.Add(pb1, 1, 1);
            //tlpImageMatches.Controls.Add(pb1, 2, 1);
            //tlpImageMatches.Controls.Add(pb1, 3, 1);
            //tlpImageMatches.Controls.Add(pb1, 4, 1);
            //tlpImageMatches.Controls.Add(pb1, 5, 1);
            //tlpImageMatches.Controls.Add(pb1, 6, 1);
            //tlpImageMatches.Controls.Add(pb1, 7, 1);

        }
    }
}
