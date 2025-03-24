using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfm2.Classes
{
    public class Product
    {
        public BindingList<Part> AssociatedParts;
        public int ProductID;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

        public Product(BindingList<Part> parts, int proid, string name, decimal price, int instock, int min, int max)
        {
            this.AssociatedParts = parts;
            this.ProductID = proid;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;
        }

        public void addAssociatedPart(Part)
        {

        }

        public bool removeAssociatedPart(int id)
        {

        }

        public Part lookupAssociatedPart(int partID)
        {

        }
    }
}
