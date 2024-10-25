using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Car: Vehicle, IRentable
    {
        int numberofdoors;

        public Car()
        {
            
        }

        public Car(int numberofdoors)
        {
            this.numberofdoors = numberofdoors;
        }

        public int Numberofdoors { get => numberofdoors; set => numberofdoors = value; }

        public override string GetDetails()
        {
            Console.WriteLine($"{base.GetDetails()}, Doors: {numberofdoors}") ;
        }

        public void Rent()
        {
            if (Isavailable)
            {
                Isavailable = false;
                VehicleRented();
            }
            else
            {
                Console.WriteLine("This car is already rented.");
            }
        }

        public void Return()
        {
            Isavailable = true;
        }


    }
}
