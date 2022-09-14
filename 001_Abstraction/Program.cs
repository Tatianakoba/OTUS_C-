using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Abstraction
{
    //Абстрактный класс
    abstract class AbstractClass
    {
        public abstract void Method();
    }
    //Конкретный класс
    class ConcreteClass: AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementation");
        }
    }
    internal class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();
            instance.Method();

            Console.ReadKey();
        }
    }
}
