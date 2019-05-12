using System;

namespace Principles
{
    class Program
    {
        public interface IVehicle
        {
            void Drive();
            void Fly();
        }
        public class StrongMultiCar : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("我可以在地上跑");
            }

            public void Fly()
            {
                Console.WriteLine("我也很能飛");
            }
        }

        public class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("駕駛車輛");
            }

            public void Fly()
            {
                Console.WriteLine("我無法飛行");
            }
        }

        public class AirPlane : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("在地上駕駛不是我的專長");
            }

            public void Fly()
            {
                Console.WriteLine("我可以在天上飛行");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
