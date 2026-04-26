using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Dynamic.Entities
{
    public abstract class Vehicle
    {
        string modelNo;
        int yearMake;
        int numberOfGears;
        int engineCapacityInCC;
        VehicleType type;

        public Vehicle(string modelNo, int yearMake, int numberOfGears, int engineCapacityInCC, VehicleType type)
        {
            this.modelNo = modelNo;
            this.yearMake = yearMake;
            this.numberOfGears = numberOfGears;
            this.engineCapacityInCC = engineCapacityInCC;
            this.type = type;
        }

        public abstract string ModelNo { get; set ; }
        public abstract int YearMake { get; set; }
        public abstract int NumberOfGears { get; set; }
        public abstract int EngineCapacityInCC { get; set; }
        public abstract VehicleType Type { get; set; }

        public abstract void GetDetails();
    }
}
