using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Интерфейсы
namespace Interfaces
{
    interface IInterface
    {
        void Method();

    }
    class MyClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Метод реализации интерфейса");
        }
    }
    internal class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            my.Method();

            Console.ReadKey();
        }
    }
}
