using System;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }
        //추상메소드
        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
        //      public void PrivateMethodA(){
        //          Console.WriteLine("PrivateMethodA()");
        //      }
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
            //  obj.PrivateMethodA();
        }
    }
}
