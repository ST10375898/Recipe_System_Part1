using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_part1._0
{
    internal class Ingrediant
    {
        private string name="";
        private string measureUnit="";
        private double quantity;

        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }


        public string MeasureUnit
        {
            get { return measureUnit; }
            set { measureUnit = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
