using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Chevy";
            car.Model = "Tahoe";
            car.Year = 2018;

            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);
        }
    }
}
