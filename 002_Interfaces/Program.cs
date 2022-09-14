using System;
//Множественное наследование.

namespace _002_Interfaces
{
    internal class Program
    {
        static void Main()
        {
            IInterface1 instance1 = new DerivedClass();
            IInterface2 instance2 = new DerivedClass();
            instance1.Method1();
            instance2.Method2();

            Console.ReadKey();
        }
    }
}
