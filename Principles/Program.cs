using System;

namespace Principles
{
    class Program
    {
        // 新創公司製造多功能用途飛行載具，但為了維持公司營運，也必須生產平價交通工具維持營收。
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

        // 生產平價汽車
        public class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("駕駛車輛");
            }

            public void Fly()
            {
                // 無法實作，難道就留空白?
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
