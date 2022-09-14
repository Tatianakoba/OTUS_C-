using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создание экземпляра по слабой ссылке. (Анонимные объекты)
namespace _011_Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Hello World!");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new MyClass().Method();

            Console.ReadKey();
        }
    }
}
