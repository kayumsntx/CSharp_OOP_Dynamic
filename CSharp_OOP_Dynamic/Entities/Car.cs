using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Dynamic.Entities
{
    public sealed class Car : FourWheeler
    {
        int numberOfDoors;
        int numberOfSeats;

        public Car(int numberOfDoors, int numberOfSeats, string modelNo, int yearMake, int numberOfGears,
            int engineCapacityInCC, VehicleType type) : base(modelNo, yearMake, numberOfGears, engineCapacityInCC, type)
        {
            this.NumberOfDoors = numberOfDoors;
            this.NumberOfSeats = numberOfSeats;
        }

        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
        public override void StopMethod()
        {
            Console.WriteLine("Car is stopping");
        }

        public override void GetDetails()
            {
            Console.WriteLine($"ModelNo: {ModelNo}\nYearMake: {YearMake}\nNumberOfGears: {NumberOfGears}\nEngineCapacityInCC: {EngineCapacityInCC}\nType: {Type}\nNumberOfDoors: {NumberOfDoors}\nNumberOfSeats: {NumberOfSeats}");

        }
    }
}
