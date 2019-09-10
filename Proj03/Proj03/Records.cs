using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj03
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public string vin;

        public Car(string make, string model, int year, string vin)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.vin = vin;
        }
        public override string ToString()
        {
            return year+" "+make+" "+model+" "+vin;
        } 
    }
}
