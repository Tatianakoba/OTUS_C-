using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;
            instance.field4 = 4;
            instance.field5 = 5;


            //Приведение экземпляра класса DerivedClass к базовому типу BaseClass
            BaseClass newinstance = (BaseClass)instance; //Upcast

            Console.WriteLine(newinstance.field1);
            Console.WriteLine(newinstance.field2);
            Console.WriteLine(newinstance.field3);

            //Проверка
            Console.WriteLine("Instance Id {0}", instance.GetHashCode());
            Console.WriteLine("newinstance Id {0}",newinstance.GetHashCode());

            Console.ReadKey();


        }
    }
}
