using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.Run();
            
        }

        interface VehicleBase
        {
            void Stop();
            void Fill();
            void Run();
        }
        abstract class Vehicle : VehicleBase
        {
            public void Stop()
            {
                Console.WriteLine("Stopped");
            }

            public void Fill()
            {
                Console.WriteLine("Pay and fill...");
            }

            abstract public void Run();
        }

        class Car : Vehicle
        {
            public override void Run()
            {
                Console.WriteLine("Car is running");
            }
        }

        class Truck : Vehicle
        {
            public override void Run()
            {
                Console.WriteLine("Truck is running");
            }
        }

        class RaceCar : Vehicle
        {
            public override void Run()
            {
                Console.WriteLine("Race car is running ... ");
            }
        }
    }
}