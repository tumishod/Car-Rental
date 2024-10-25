using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public abstract class Vehicle 
    {
        string make;
        string model;
        int year;
        int rentalrateperday;
        bool isavailable;

        public Vehicle()
        {
            
        }

        public Vehicle(string make, string model, int year, int rentalrateperday, bool isavailable)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.rentalrateperday = rentalrateperday;
            this.isavailable = isavailable;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public decimal Rentalrateperday { get => rentalrateperday; set => rentalrateperday = (int)value; }
        public bool Isavailable { get => isavailable; set => isavailable = value; }

        public virtual string GetDetails()
        {
            Console.WriteLine($"{make} {model} {year}  {rentalrateperday}, it will be available {isavailable}");
        }

        public event EventHandler OnVehicleRented;

        protected void VehicleRented()
        {
            OnVehicleRented.Invoke(this, EventArgs.Empty);
        }
    }


}
