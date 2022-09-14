using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//передача экземпляра класса в качестве аругмента метода
namespace _009_Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Вызван метод класса MyClass");
        }
    }
    class MyClass2
    {
        //на след строке создаем метод CallMethod, который принимает один аргумент типа MyClass и ничего не возвращает
        public void CallMethod(MyClass my)
        {
            //в теле метода CallMethod вызываем метод с именем Method аргумента my
            my.Method();
        }
    }


    internal class Program
    {


        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            MyClass2 my2 = new MyClass2();
            my2.CallMethod(my);

            Console.ReadKey();

        }
    }
}
