using System;

namespace TestAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal startPrice = 6000m;
            decimal endPrice = 12000m;


            ///2.A
            ///
            var cars = new Car[10]
            {
                new Car("Chevy", "Camaro", "White", 35000m),
                new Car("Mersedes", "E-Class", "Black", 45000m),
                new Car("Nissan", "GTR", "Green", 25000m),
                new Car("BMW", "M3", "White", 120000m),
                new Car("Tayota", "Camry", "Black", 10000m),
                new Car("Hyundai", "Sanata", "Green", 5000m),
                new Car("Mazda", "3", "White", 43000m),
                new Car("Skoda", "Octavia", "Black", 40000m),
                new Car("Ford", "Mustang", "Green", 10000m),
                new Car("Fiat", "500", "White", 36000m)
            };

            Console.WriteLine("List of cars:");
            Console.WriteLine();

            foreach (var item in cars)
            {
                item.GetInfo();
            }


            ///2.B

            Console.WriteLine("\n");
            Console.WriteLine("White or Black color cars:");
            Console.WriteLine();

            foreach (var item in cars)
            {
                if(item.Color == "White" || item.Color == "Black")
                {
                    item.GetInfo();
                }
            }


            ///2.C


            Console.WriteLine();
            Console.WriteLine($"Cars price between {startPrice:C} and {endPrice:C}:\n");

            foreach (var item in cars)
            {
                if(item.Price >= startPrice && item.Price <= endPrice)
                {
                    item.GetInfo();
                }
            }

        }
    }
}
