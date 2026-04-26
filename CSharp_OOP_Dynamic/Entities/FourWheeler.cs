using CSharp_OOP_Dynamic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Dynamic.Entities
{
    public class FourWheeler : Vehicle, IInteriorDesign
    {
        public FourWheeler(string modelNo, int yearMake, int numberOfGears, int engineCapacityInCC,
            VehicleType type) : base(modelNo, yearMake, numberOfGears, engineCapacityInCC, type)
        {
            ModelNo = modelNo;
            YearMake = yearMake;
            NumberOfGears = numberOfGears;
            EngineCapacityInCC = engineCapacityInCC;
            Type = type;
        }

        public override string ModelNo { get; set; }
        public override int YearMake { get; set; }
        public override int NumberOfGears { get; set; }
        public override int EngineCapacityInCC { get; set; }
        public override VehicleType Type { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Abstract Method Override in FourWheeler Class");
        }
        public string[] GetInteriorDesign(string design)
        {
            string[] interiorDesign=design.Split(',');
            return interiorDesign;

        }
        public virtual void StopMethod()
        {
            Console.WriteLine("FourWheeler is stopping");
        }

    }
}
