using System;

namespace CarProductionLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Toyota", "red");
            var saloonCar1 = new SaloonCar(2);
            var saloonCar2 = new SaloonCar(3, "Nissan");
            var saloonCar3 = new SaloonCar(4, "Ford", "purple");

            Console.WriteLine("car1 is a " + car1.color + " " + car1.manufacturer);
            Console.WriteLine("saloonCar1 has " + saloonCar1.numberOfSeats + " Seats");
            Console.WriteLine("saloonCar2 has " + saloonCar2.numberOfSeats + " Seats" + " and is a " + saloonCar2.manufacturer);
            Console.WriteLine("saloonCar3 has " + saloonCar3.numberOfSeats + " Seats" + " and is a " + saloonCar3.color + " " + saloonCar3.manufacturer);

        }
    }

    // Car class demonstrates polymorphism. Its constructors can accept various numbers of parameters.
    public class Car
    {
        public Car() { }

        public Car(string _manufacturer)
        {
            this.manufacturer = _manufacturer;
        }
        public Car (string _manufacturer, string _color) 
            : this(_manufacturer)
        {
            this.color = _color;
        }

        public string color { get; set; }
        public string manufacturer { get; set; }
    }

    // SaloonCar class demonstrates inheritance.  It inherits from Car class.
    // SaloonCar class demonstrates polymorphism. Its contructors can accept various number of parameters.
    public class SaloonCar : Car
    {
        public SaloonCar(int _numberOfSeats)
        {
            this.numberOfSeats = _numberOfSeats;                
        }

        public SaloonCar(int _numberOfSeats, string _manfacturer) 
            : base(_manfacturer) 
        {
            this.numberOfSeats = _numberOfSeats;
        }

        public SaloonCar(int _numberOfSeats, string _manfacturer, string _color) 
            : base(_manfacturer, _color)
        {
            this.numberOfSeats = _numberOfSeats;
        }

        public int numberOfSeats { get; set; }
    }
}
