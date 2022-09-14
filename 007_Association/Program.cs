using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Association
{
    class MyClass1
    {
        public MyClass1()
        {
            Console.WriteLine("Создан экземпляр класса MyClass1");
        }
    }
    class MyClass2
    {
        private MyClass1 myObj = null;
        
            //данный метод не является фабричным
            public void Method()
            {
                myObj = new MyClass1();
            }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass2 my = new MyClass2();
            my.Method();
            Console.ReadKey();
        }
    }
}
