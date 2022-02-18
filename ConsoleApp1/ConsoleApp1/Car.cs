using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    { 
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;

        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model, string color, int maxspeed):this(brand, model)
        {
            Color = color;
            MaxSpeed = maxspeed;
        }

        public virtual string Info()
        {
            return $"Brand: {Brand}\nModel: {Model}\nColor: {Color}\nMaxSpeed: {MaxSpeed}";
        }
    }
}
