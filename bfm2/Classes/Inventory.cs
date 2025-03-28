using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfm2
{
    public class Inventory
    {
        public BindingList<Product> Products;
        public BindingList<Part> AllParts;
        public Inventory()
        {
            this.AllParts = new BindingList<Part>() {
                new InHouse(0, "Wheel", 12.11m, 13, 5, 25, 1),
                new Outsourced(1, "Pedal", 8.22m, 11, 5, 25, "MegaPedal"),
                new Outsourced(2, "Chain", 8.33m, 12, 5, 25, "BikeMaster"),
                new InHouse(3, "Seat", 42.55m, 8, 2, 15, 1)
                };
            this.Products = new BindingList<Product>() {
                new Product(AllParts, 0, "Red Bicycle", 167.94m, 15, 1, 25),
                new Product(AllParts, 1, "White Bicycle", 197.94m, 13, 1, 25),
                new Product(AllParts, 2, "Green Bicycle", 117.94m, 4, 1, 25)
                };
        }

        public void addProduct(Product product, BindingList<Part> partlist, int id, string name, decimal price, int stock, int min, int max)
        {
            Product newProduct = new Product(partlist, id, name, price, stock, min, max);
            Products.Add(newProduct);
        }
        public bool removeProduct(int number)
        {
            if (lookupProduct(number) != null) {
                Products.Remove(lookupProduct(number));
                MessageBox.Show($"Item {number} deleted!");
                return true;
            } else
            {
                MessageBox.Show($"Item {number} not found.");
                return false;
            }
        }
        public Product lookupProduct(int number)
        {
            return Products[0];
        }

        public void updateProduct(int number, Product product)
        {

        }

        public void addPart(Part part) { }
        public bool deletePart(Part part)
        {
            return false;
        }

        public Part lookupPart(int number) {
            return AllParts[number];

        }
        public void updatePart(int number, Part part) { }
    }
}
