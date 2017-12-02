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
    public interface IInventoryProductEditor
    {
    }

    public partial class UCInventoryProductEditor : UserControl, IInventoryProductEditor
    {
        public UCInventoryProductEditor()
        {
            InitializeComponent();
        }

    }
}
