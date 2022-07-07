using System;

namespace Quiz05Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car x = new Car();
            x.vin = "654321";
            x.make = "Tesla";
            x.model = "3";
            x.mileage = 1488;
            Car y = new Car("123456", "Dodge", "Caravan", 0);
            Console.Write($"Car {x.make} new mileage is: ");
            x.Drive(1000);
            Console.WriteLine();
            Console.Write($"Car {y.make} new mileage is: ");
            y.Drive(2000);
            Console.WriteLine();
            Console.WriteLine("Car x Details Below:");
            x.Display();
            Console.WriteLine();
            Console.WriteLine("Car y Details Below:");
            y.Display();
        }
    }
    public class Car
    {
        public string vin;
        public string make;
        public string model;
        public int mileage;

        public Car()
        {
            this.vin = "xxxxxxxxxx";
            this.make = "Unknown";
            this.model = "Unknown";
            this.mileage = 0;
        }
        public Car(string vin, string make, string model, int mileage)
        {
            this.vin = vin;
            this.make = make;
            this.model = model;
            this.mileage = mileage;
        }

        public void Drive(int miles)
        {
            this.mileage = this.mileage + miles;
            Console.WriteLine(this.mileage);
        }
        public void Display()
        {
            Console.WriteLine(this.vin);
            Console.WriteLine(this.make);
            Console.WriteLine(this.model);
            Console.WriteLine(this.mileage);
        }
    }

}
