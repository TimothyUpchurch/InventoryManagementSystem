using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public abstract class Part
    {
        public Part(string name, int stock, decimal price, int min, int max)
        {   
            PartId = staticID;
            Name = name;
            InStock = stock;
            Price = price;
            Min = min;
            Max = max;
        }
        // init static id
        public static int staticID = 0;
        [System.ComponentModel.DisplayName("Part ID")]
        public int PartId { get; set; }
        [System.ComponentModel.DisplayName("Part Name")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [System.ComponentModel.DisplayName("In Stock")]
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

}
