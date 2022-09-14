using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Наследование
//Базовый класс - Производный класс
//Супер класс - Подкласс (сабкласс)
//Родительский класс - Дочерний класс
//Родитель - Потомок
namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            Console.WriteLine(instance.publicField);

            Console.ReadKey(); 
        }
    }
}
