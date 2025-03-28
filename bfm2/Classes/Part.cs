using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfm2
{
    public class Part
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Part(int PartID, string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.PartID = PartID;
            this.PartName = Name;
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
