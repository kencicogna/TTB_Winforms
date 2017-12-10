﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Models;

namespace ProductManager.Events
{
    public class InventoryProductDetailsLineItems : IApplicationEvent
    {
        public List<InventoryItem> inventoryItems { get; set; }
    }
}