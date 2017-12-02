using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Events
{
    class InventoryProductSearch : IApplicationEvent
    {
        public String SearchString { get; set; }
    }
}
