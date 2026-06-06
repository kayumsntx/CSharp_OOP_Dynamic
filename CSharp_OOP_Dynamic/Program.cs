using CSharp_OOP_Dynamic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoTask();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }

        private static void DoTask()
        {
            while (true)
            {
                Console.WriteLine("1. Car | 2. MotorCycle | 3. Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 3)
                    break;
                switch (choice)
                {
                    case 1:
                        printCar();
                        break;
                    case 2:
                        printMotorCycle();
                        break;

                    default:
                        Console.WriteLine("Invalid Numbers, Try Again");
                        break;
                            

                }



            }
        }

        private static void printMotorCycle()
        {
            MotorCycle cycle = new MotorCycle(150, 200, 120, "Liquid", "Disc", "Disc", "CBR150R", 2020, 6, 200, VehicleType.Private);
            cycle.StartMethod();
            cycle.StartMethod("Bummmm");
            cycle.StartMethod(DateTime.Now);
            cycle.GetDetails();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Exterior Desing");
            string[] designs = cycle.GetExteriorDesign("Flower,Perfume,kodom");
            for (int i = 0; i < designs.Length; i++)
            {
                Console.WriteLine($"{i + 1} {designs[i]}");
            }


        }

        private static void printCar()
        {
            Car myCar = new Car(4, 5, "Civic", 2020, 6, 2000, VehicleType.Private);
            myCar.GetDetails();
            myCar.StopMethod();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Interior Desing");
            string[] design = myCar.GetInteriorDesign("Leather,Wooden,Plastic");
            for (int i = 0; i < design.Length; i++)
            {
                Console.WriteLine($"{i + 1} {design[i]}");
            }
        }
    }
}
