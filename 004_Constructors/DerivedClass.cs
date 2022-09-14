using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Constructors
{
    class DerivedClass: BaseClass
    {
        public int derivedField;
        //конструктор по умолчанию
        public DerivedClass()
        {

        }
        //Пользовательский конструктор
        //Вызывается пользовательский конструктор базового класса, при этом не нужно
        //присваивать значения, унаследованным членам в конструкторе производного класса.
        public DerivedClass(int number1, int number2)
            :base(number1)
        {
            derivedField = number2;
        }
    }
}
