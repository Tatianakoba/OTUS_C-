﻿using System;
//Множественное наследование от одного класса и нескольких интерфейсов

namespace _004_Inteerfaces
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();
            instance.Method1();
            instance.Method2();

            Console.WriteLine(new String('-', 40));
            BaseClass instance0 = instance as BaseClass;
            instance0.Method();

            Interface1 instance1 = instance as Interface1;
            instance1.Method1();

            Interface2 instance2 = instance as Interface2;
            instance2.Method2();

            Console.ReadKey();
        }
    }
}
