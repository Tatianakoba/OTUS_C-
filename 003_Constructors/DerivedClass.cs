using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constructors
{
     class DerivedClass: BaseClass
    {
        public int derivedField;
        //конструктор по умолчанию
        //PublicDerivedClass()
        //{
        //}

        //пользовательский конструкто
        //при создании объекта производного класс, конструктор производного класса
        //автоматически вызывает конструкто по умолчанию из базового класса
        //конструктор базового класса, присовит всем данным какие-то свои безопасные значения
        //после этого начнет работу конструктор производного класса ,который повторно 
        //будет определять значения для унаследования членов (ДВОНАЯ РАБОТА!)
        public DerivedClass (int number1, int number2)
        {
            //инициализируем поле базового класса
            baseNumber = number1;
            //инициализируем поле производного (данного) класса
            derivedField = number2;
        }
    }
}
