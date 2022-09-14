using System;


namespace _004_Abstraction
{
    internal class Program
    {
        static void Main()
        {
            ConcreteDerivedClass instance = new ConcreteDerivedClass();

            instance.SimpleMethod();
            instance.VirtualMethod();
            instance.AbstractMethod();

            Console.ReadKey();
        }
    }
}
