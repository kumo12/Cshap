using System;

namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    //다중상속
    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            //IFlyable flyable = new FlyingCar(); as IFlyable;
            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();

        }
    }
}
