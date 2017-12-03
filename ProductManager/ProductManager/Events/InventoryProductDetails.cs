using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Events
{
    public class InventoryProductDetails : IApplicationEvent
    {
        public String SKU { get; set; }
    }
}
