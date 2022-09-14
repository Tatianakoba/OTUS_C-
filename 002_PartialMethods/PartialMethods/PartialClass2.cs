using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    partial class PartialClass
    {
        //определение частичного метода
        partial void PartialMethod()
        {
            Console.WriteLine("Вызван частичный метод - PartialMethod()");
        }
        //вызов частичного метода через метод обертку
        public void CallPartialMethod()
        {
            PartialMethod();
            //при вызове нереализованного частичного метода, компилятор его проигнорирует и ошибки уровня выполнения не будет
            MyMethod();
        }
        #region Реализация частичных методов в других частях класса не обязательна!
        //partial void MyMethod()
        //{
        //    Console.WriteLine("Реализация частичных методов в других частях класса PartialClass -необязательна"); ;
        //}
        #endregion

    }

}
