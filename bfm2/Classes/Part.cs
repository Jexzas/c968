using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfm2.Classes
{
    public class Part
    {
        public int PartID;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;
        public Part(int PartID, string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.PartID = PartID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }
    }
    public class InHouse : Part
    {
        public int MachineID;

        public InHouse(int PartID, string Name, decimal Price, int InStock, int Min, int Max, int MachineID)
            : base(PartID, Name, Price, InStock, Min, Max)
        {
            this.MachineID = MachineID;
        }
    }

    public class Outsourced : Part
    {
        public string CompanyName;

        public Outsourced(int PartID, string Name, decimal Price, int InStock, int Min, int Max, string CompanyName)
            : base(PartID, Name, Price, InStock, Min, Max)
        {
            this.CompanyName = CompanyName;
        }
    }
}
