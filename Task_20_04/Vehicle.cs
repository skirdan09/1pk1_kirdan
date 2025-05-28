using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    internal class Vehicle
    {
        public VehicleType Type { get; set; }
        public Vehicle(VehicleType type)
        {
            Type = type;
        }

        public class VehicleRegistry
        {
            private List<Vehicle> vehicles;
            public VehicleRegistry()
            {
                vehicles = new List<Vehicle>();
            }

            public void AddVehicle(Vehicle vehicle)
            {
                vehicles.Add(vehicle);
            }

            public int CountVehiclesByType(VehicleType type)
            {
                return vehicles.Count(v => v.Type == type);
            }
        }
    }
}
