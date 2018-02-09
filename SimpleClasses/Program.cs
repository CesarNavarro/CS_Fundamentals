using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            
            myCar.Make = "BMW";
            myCar.Model = "X1";
            myCar.Year = 2010;
            myCar.Color = "White";

            Console.WriteLine("A {0} {1} of {2} has a market value of {3}.", 
                myCar.Make,
                myCar.Model,
                myCar.Year,
                String.Format("{0:C}", myCar.GetMarketValue()));

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
                
        public decimal GetMarketValue()
        {
            decimal carValue = 100.0M;

            if (this.Year > 2005)
                carValue = 15000;
            else
                carValue = 2000;

            return carValue;
        }

    }
}
