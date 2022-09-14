using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class MyClass
    {
        MyClass my = null;
        private void Method()
        {
            Console.WriteLine("Hello");
        }
        public void CallMethod()
        {
            my = new MyClass();
            //private метод виден на экземпляре
            my.Method();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.CallMethod();
            //my.Method(); недопустимо
            Console.ReadKey();
        }
    }
}
