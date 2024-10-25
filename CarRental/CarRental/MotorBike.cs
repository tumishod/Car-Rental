using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class MotorBike: Vehicle, IRentable
    {
        bool hassidecar;

        public MotorBike()
        {
            
        }

        public MotorBike(bool hassidecar)
        {
            this.hassidecar = hassidecar;
        }

        public bool Hassidecar { get => hassidecar; set => hassidecar = value; }
    }

    public override string GetDetails()
    {
        Console.WriteLine($"{base.GetDetails()}, Side car: {hassidecar}") ;
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
            Console.WriteLine("This motorbike is already rented.");
        }
    }

    public void Return()
    {
        Isavailable = true;
    }


}
