using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMartStore
{
    public abstract class Category
    {
        public string Name { get; set; }
        public abstract double GSTPercentage { get; }
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }

        public double FinalRate
        {
            get
            {
                return (PricePerUnit * Quantity) + ((PricePerUnit * Quantity) * (GSTPercentage / 100));
            }
        }
    }
}
