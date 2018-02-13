using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "BMW";
            car1.Model = "X1";
            car1.VIN = "A1";
            
            Car car2 = new Car();
            car2.Make = "MINI";
            car2.Model = "Cooper";
            car2.VIN = "B2";
            */
            Book book1 = new Book();
            book1.Author = "Arturo Perez";
            book1.Title = "Capital Alatriste";
            book1.ISBN = "00-000-0000-0";

            /*
            // ArrayList are dinamically sized,
            // cool features soeting, remove items
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(book1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            /*
            // Dictionary<Tkey, TValue>
            Dictionary<string , Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            //string[] names = {"Pepe", "Juan", "Oscar"};

            // Object initializer
            // No need for a constructor
            //Car car1 = new Car() { Make = "BMW", Model = "X1", VIN = "C3" };
            //Car car2 = new Car() { Make = "MINI", Model = "Cooper", VIN = "C4" };

            // Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "BMW", Model = "X1", VIN = "C3" },
                new Car { Make = "MINI", Model = "Cooper", VIN = "C4" }
            };

            Console.WriteLine(myList[1].Model);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
