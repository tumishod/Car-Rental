using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();

            Car car1 = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2016,
                Rentalrateperday = 100,
                Isavailable = true,
                Numberofdoors = 4
            };

            MotorBike motorbike1 = new MotorBike
            {
                Make = "kawasaki",
                Model = "Ninja",
                Year = 2018,
                Rentalrateperday = 60,
                Isavailable = true,
                Hassidecar = true,
            };

            Console.WriteLine("Available Vehicles:");
            Console.WriteLine(list.Count);
        }
    }
}
