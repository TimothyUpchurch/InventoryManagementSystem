using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        public BindingList<Product> Products = new BindingList<Product>();
        public BindingList<Part> AllParts = new BindingList<Part>();
        // Constructor
        public Inventory()
        {
            
        }

        // ----- Parts -----
        public void addPart(Part part)
        {
            Part.staticID++;
            AllParts.Add(part);       
        }
        public bool deletePart(Part part)
        {
            AllParts.Remove(part);
            // resets id to 0 if all rows deleted. 
            if (AllParts.Count == 0)
            {
                Part.staticID = 0;
            }
            return true;
        }
        public void updatePart(int i, Part part)
        {
            for (int x = 0; x < AllParts.Count; x++)
            {
                if (AllParts[x].PartId == i)
                {
                    //sets part id to its current id
                    part.PartId = i;
                    AllParts[x] = part;
                    break;
                }
            }
            // sets id to end of list.
            Part.staticID = addToEndList(AllParts);
        }
        public Part lookupPart(int i)
        {
            return AllParts[i];
        }

        // ----- Products -----
        public void addProduct(Product product)
        {
            Product.staticID++;
            Products.Add(product);
        }
        public bool removeProduct(int x)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == x)
                {
                    Products.Remove(Products[i]);
                    break;
                }
            }
            // resets id to 0 if all rows deleted. 
            if (Products.Count == 0)
            {
                Product.staticID = 0;
            }
            return true;
        }
        public void updateProduct(int i, Product product)
        {
            for(int x = 0; x < Products.Count; x++)
            {
                if (Products[x].ProductID == i)
                {
                    product.ProductID = i;
                    Products[x] = product;
                    break;
                }
            }

            // set the ID to the end of the list.
            Product.staticID = addToEndProduct(Products);
        }
        public Product lookupProduct(int i)
        {
            return Products[i];
        }
        
        //resets static id after updating an item.
        private int addToEndList(BindingList<Part> parts)
        {
            if (parts.Count > 0)
            {
                List<int> max = new List<int>();
                foreach (Part part in parts)
                {
                    max.Add(part.PartId);
                }
                return max.Max() + 1;
            }
            return 0;
        }
        private int addToEndProduct(BindingList<Product> products)
        {
            if (products.Count > 0)
            {
                List<int> max = new List<int>();
                foreach (Product prod in products)
                {
                    max.Add(prod.ProductID);
                };
                return max.Max() + 1;
            }
            return 0;
        }
    }
}
