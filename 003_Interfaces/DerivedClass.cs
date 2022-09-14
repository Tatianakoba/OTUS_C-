using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Interfaces
{
    class DerivedClass : Interface1, Interface2
    {
        // Далее реализуем метод из базового интерфейса.
        //При реализации используется техника явного указания имени интерфейса 
        // в имени метода, которому принадлежит данный метод.

        //По умолчанию одноименные методы являются private,
        //но явно указывать модификаторы доступ нендопустимо

        void Interface1.Method()
        {
            Console.WriteLine("Реализация метода Method() из Interface1");

        }

        void Interface2.Method()
        {
            Console.WriteLine("Реализация метода Method() из Interface2");

        }
    }
}
