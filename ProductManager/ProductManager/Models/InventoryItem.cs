using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProductManager.Models
{
    public class InventoryItem
    {
        public String BinRack { get; set; }
        public String Cost { get; set; }
        public Image PrimaryPicture { get; set; }
        public String PrimaryPictureURL { get; }
        public String SKU { get; set; }
        public String Title { get; set; }
        public String Variations { get; set; }
    }
}
