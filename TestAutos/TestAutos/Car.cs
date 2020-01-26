using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutos
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public string Color { get; }
        public decimal Price { get; }

        public Car(string brand, string model, string color, decimal price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Price = price;
        }

        public void GetInfo()
        {
            Console.WriteLine($"brand: {Brand,10},  model:{Model, 10},\tcolor:\t{Color},\tprice:\t{Price,6}");
        }


    }
}
