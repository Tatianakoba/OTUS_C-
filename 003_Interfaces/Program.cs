using System;
//Явное указание имени интерфейса в имени метода.

namespace _003_Interfaces
{
    internal class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            //instance //на экземпляре не видим меотдов интерфейсов
            //Приведем экземпляр DerivedClass - instance к базовому интерфейсному типу Interface1
            Interface1 instance1 = instance as Interface1;
            instance1.Method();

            Interface2 instance2 = instance as Interface2;
            instance2.Method();

            Console.ReadKey();
        }
    }
}
