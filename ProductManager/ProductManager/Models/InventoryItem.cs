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
        public InventoryItem()
        {
            VariationItems = new List<InventoryItem>();
        }

        public int Id { get; set; }
        public String SKU { get; set; }
        public String Variation { get; set; }
        public String Title { get; set; }
        public String ShortTitle { get; set; }
        public String BinRack { get; set; }
        public String Cost { get; set; }
        public String Supplier { get; set; }
        public Image PrimaryPicture { get; set; }
        public String PrimaryPictureURL { get; }
        public int Weight { get; set; }
        public decimal PackagedWeight  { get; set; }
        public String BubbleWrap { get; set; }
        public String PackagingType { get; set; }
        public String EbayItemID { get; set; }
        public String ASIN { get; set; }
        public String UPC { get; set; }
        public String Location { get; set; }
        public bool ActiveOnEbay { get; set; }
        public bool ActiveOnAmazon { get; set; }
        public bool ActiveOnFacebook { get; set; }
        public bool IsParent { get; set; }
        public DateTime LastModified { get; set; }

        public List<InventoryItem> VariationItems { get; set; }
    }
}
