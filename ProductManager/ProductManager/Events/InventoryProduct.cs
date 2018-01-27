using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Models;

namespace ProductManager.Events
{
    public class InventoryProductDetails : IApplicationEvent
    {
        public InventoryItem inventoryItem { get; set; }
    }
}
