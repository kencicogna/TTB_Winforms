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
    public interface IInventoryView
    {
        String BinRack { get; set; }
        String Cost { get; set; }
        Image PrimaryPicture { get; set; }
        String PrimaryPictureURL { get; }
        String SKU { get; set; }
        String Title { get; set; }
        String Variations { get; set; }
    }

    public partial class UserControlInventory : UserControl, IInventoryView
    {
        public string BinRack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Image PrimaryPicture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string PrimaryPictureURL => throw new NotImplementedException();

        public string SKU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Variations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public UserControlInventory()
        {
            InitializeComponent();

        }

        private void btnShowSearchResultsView_Click(object sender, EventArgs e)
        {
            ucInventorySearchResults1.Show();
            ucInventoryProductEditor1.Hide();
        }

        private void btnShowProductView_Click(object sender, EventArgs e)
        {
            ucInventorySearchResults1.Hide();
            ucInventoryProductEditor1.Show();
        }
    }
}
