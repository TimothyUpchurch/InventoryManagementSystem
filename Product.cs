using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public static int staticID = 0;
        [System.ComponentModel.DisplayName("Product ID")]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [System.ComponentModel.DisplayName("In Stock")]
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // Constructor
        public Product()
        {

        }
        public Product(BindingList<Part> AssociatedParts, string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.AssociatedParts = AssociatedParts;
            ProductID = staticID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int x)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartId == x)
                {
                    AssociatedParts.Remove(AssociatedParts[i]);
                    break;
                }
            }
            return true;
        }
        public Part lookupAssociatedPart(int i)
        {
            return AssociatedParts[i];
        }
        
    }
}
