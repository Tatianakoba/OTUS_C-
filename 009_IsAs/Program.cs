﻿using System;
//Операторы Is и As

namespace _009_IsAs
{
    class ClassA { /* ... */}
    class ClassB : ClassA { /* ... */}
    internal class Program
    {
        static void Main()
        {
            ClassB b = new ClassB();
            ClassA a = null;
            // Оператор Is - проверяет совместимость объекта с заданным типом.
            //Если предоставленный объект может быть приведен к предоставленному типу не вызывая исключение,
            //выражение is принимает значение true.

            //Напримерб в следующем коде определяетсяб является ли объект экземпляром типа А или типа, производного от А:

            if (b is ClassA)
            {
                a = (ClassA)b;
            }
            else
            {
                a = null;
            }
            //_____________________________________________
            // Оператор As  используется для выполнения преобразованиц между совместимыми ссылочными типами.
            //Оператор as подобен оператору приведенияю Однако, если преобразование невозможно,
            //as возвращает значение null, а не вызывает исключение.

            //В общем виде логика работы оператора as представляет собой механизм использования оператора is
            //только в совершенном виде.
            a = b as ClassA;

            Console.ReadKey();
        }
    }
}
