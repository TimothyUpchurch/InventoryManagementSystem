using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced(string name, int stock, decimal price, int min, int max, string companyName) : base(name, stock, price, min, max)
        {
            CompanyName = companyName;
        }
    }
}
