using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class Inhouse : Part
    {
        public int MachineID { get; set; }
        public Inhouse(string name, int stock, decimal price, int min, int max, int machineID) : base(name, stock, price, min, max)
        {
            MachineID = machineID;
        }
    }
}
