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
        public String PrimaryPictureURL { get; set; }
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
        public int updateID { get; set; }   // row number in DataGridView

        public List<InventoryItem> VariationItems { get; set; }

        public InventoryItem Clone()
        {
            var clone = new InventoryItem();

            CopyFields(this,clone);

            foreach (var v in this.VariationItems)
            {
                var i = new InventoryItem();
                CopyFields(v,i);
                clone.VariationItems.Add(i);
            }

            return clone;
        }

        private void CopyFields(InventoryItem from, InventoryItem to)
        {
            to.Id = from.Id;
            to.SKU = from.SKU;
            to.Variation = from.Variation;
            to.Title = from.Title;
            to.ShortTitle = from.ShortTitle;
            to.BinRack = from.BinRack;
            to.Cost = from.Cost;
            to.Supplier = from.Supplier;
            to.PrimaryPicture = from.PrimaryPicture;
            to.PrimaryPictureURL = from.PrimaryPictureURL;
            to.Weight = from.Weight;
            to.PackagedWeight = from.PackagedWeight;
            to.BubbleWrap = from.BubbleWrap;
            to.PackagingType = from.PackagingType;
            to.EbayItemID = from.EbayItemID;
            to.ASIN = from.ASIN;
            to.UPC = from.UPC;
            to.Location = from.Location;
            to.ActiveOnEbay = from.ActiveOnEbay;
            to.ActiveOnAmazon = from.ActiveOnAmazon;
            to.ActiveOnFacebook = from.ActiveOnFacebook;
            to.IsParent = from.IsParent;
            to.LastModified = from.LastModified;
            to.updateID = from.updateID;
        }
    } // end class

} // end namespace


