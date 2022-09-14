using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Base.Method
{
    internal class DerivedClass : BaseClass
    {
        //Переопределение метода базового класса
        public override void Method()
        {
            //Вызов метода базового класса

            base.Method();

            Console.WriteLine("Method from DerivedClass");
        }
    }
}
