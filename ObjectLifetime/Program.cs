using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();
            /*
            myCar.Make = "BMW";
            myCar.Model = "X1";
            myCar.Year = 2010;
            myCar.Color = "White";
            */

            //Car myThirdcar = new Car("MINI", "COOPER", 2016, "Orange");

            /*
            Car myOthercar;
            myOthercar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOthercar.Make,
                myOthercar.Model,
                myOthercar.Year,
                myOthercar.Color);

            myOthercar.Model = "X3";
            
            Console.WriteLine("{0} {1} {2} {3}",
               myCar.Make,
               myCar.Model,
               myCar.Year,
               myCar.Color);
            
            myOthercar = null;

            Console.WriteLine("{0} {1} {2} {3}",
                myOthercar.Make,
                myOthercar.Model,
                myOthercar.Year,
                myOthercar.Color);

            myCar = null;
            */
             
            Console.ReadLine();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /*
        public Car()
        {
            // You could load from a configuration file
            // a database, etc.
            Make = "Nissan";
        }
        
        public Car(string  make, string mode, int year, string color)
        {
            Make = make;
            Model = Model;
            Year = year;
            Color = color;
        }
        */

        public static void MyMethod()
        {
            Console.WriteLine("Calling the static MyMethod");
            //Console.WriteLine(Make); //Not access available in static methods to class instance properties
        }
    }
}
