using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Dynamic.Entities
{
    public class MotorCycle : TwoWheeler
    {
        double maxPowerBPH;
        double maxTorqueNM;
        int mileageKPML;
        string cooling;
        string frontBreak;
        string rearBreak;
        public MotorCycle(double maxPowerBPH, double maxTorqueNM, int mileageKPML, string cooling, string frontBreak, string rearBreak, 
            string modelNo, int yearMake, int numberOfGears, int engineCapacityInCC, VehicleType type) : base(modelNo, yearMake, numberOfGears, engineCapacityInCC, type)
            


        {
            this.maxPowerBPH = maxPowerBPH;
            this.maxTorqueNM = maxTorqueNM;
            this.mileageKPML = mileageKPML;
            this.cooling = cooling;
            this.frontBreak = frontBreak;
            this.rearBreak = rearBreak;
        }
        public override void GetDetails()
        {
               Console.WriteLine($"Model No: {ModelNo} \nYear Make: {YearMake} \nNumber Of Gears: {NumberOfGears} \nEngine Capacity In CC: " +
                   $"{EngineCapacityInCC} \nVehicle Type: {Type} \nMax Power BPH: {maxPowerBPH} \nMax Torque NM:" +
                   $" {maxTorqueNM} \nMileage KPML: {mileageKPML} \nCooling: {cooling} \nFront Break: {frontBreak} \nRear Break: {rearBreak}"); 
        }
    }
}
