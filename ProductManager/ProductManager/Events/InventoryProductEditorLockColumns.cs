using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Models;

namespace ProductManager.Events
{
    public class InventoryProductEditorLockColumns : IApplicationEvent
    {
        public bool locked { get; set; } = false;
    }
}
