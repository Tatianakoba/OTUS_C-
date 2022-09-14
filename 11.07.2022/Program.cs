using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//классы
namespace _11._07._2022
{
    //Создаем класс с именем MyClass
    //В теле класса создаем открытое поле string с именем field и метод с именем metod
    class MyClass
    {
        public string field;
        public void Method()
        {
            Console.WriteLine(field);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Создаем экземпляр класса MyClass (по сильной ссылке)
            //2. Создаем экземпляр класса MyClass с именем instance
            //3. Инстанцируем класс MyClass
            //4. Создаем переменную с именем instance, типа MyClass и присваиваем ей адрес экземпляра на куче.
            //(instance - является ссылкой на экземпляр класса MyClass построенный на куче)
            
            MyClass instance = new MyClass();
             
            //Полю field, экземпляра instance, присваиваем значение Hello World!
            instance.field = "Hello world!";
            //Выводим на экран значение поля field экземпляра instance
            Console.WriteLine(instance.field);
            //Вызом метода с именем Method на экземпляре instance
            instance.Method();
            //Delay.
            Console.ReadKey();
        }
    }
}
