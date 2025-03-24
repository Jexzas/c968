using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfm2.Classes
{
    public class Inventory
    {
        BindingList<Product> Products;
        BindingList<Part> AllParts;
        public Inventory(BindingList<Part> allParts, BindingList<Product> allProducts)
        {
            this.AllParts = allParts;
            this.Products = allProducts;
        }

        public void addProduct(Product product)
        {

        }
        public bool removeProduct(int number)
        {

        }
        public Product lookupProduct(int number)
        {
        }

        public void updateProduct(int number, Product product)
        {

        }

        public void addPart(Part part) { }
        public bool deletePart(Part part)
        {

        }

        public Part lookupPart(int number) { };
        public void updatePart(int number, Part part) { };
    }
}
