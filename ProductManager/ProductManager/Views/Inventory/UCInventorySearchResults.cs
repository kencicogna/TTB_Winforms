﻿using System;
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
            EventAggregator.Instance.Publish(new InventoryShowSearchResultView());

            flpSearchMatches.Controls.Clear();

            decimal itemCount = inventorySearchResults.InventoryItems.Count();

            for (var i=0; i < itemCount; i++)
            {
                var row = (int)Math.Floor( (decimal)i / 6);
                var col = (int)itemCount % 6;

                var pb = new PictureBox();
                pb.Name = inventorySearchResults.InventoryItems[i].SKU;
                pb.Size = new Size(175, 175);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                Image thumb = inventorySearchResults.InventoryItems[i].PrimaryPicture.GetThumbnailImage(175, 175, null, IntPtr.Zero);
                pb.Image = thumb;

                pb.Click += new EventHandler(OnImageClick);

                pb.Tag = inventorySearchResults.InventoryItems[i];

                // Add Image to FlowLayoutPanel
                flpSearchMatches.Controls.Add(pb);
            }

        }

        private void OnImageClick(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            EventAggregator.Instance.Publish(new InventoryProductDetails { inventoryItem = (InventoryItem)pb.Tag });
        }

    }
}
