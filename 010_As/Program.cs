using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_As
{
    internal class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //UpCast (Привели к базовому типу)
            BaseClass instanceUp = instance as BaseClass;
            instanceUp.Method();

            //DownCast
            DerivedClass instanceDown = instanceUp as DerivedClass;
            instanceDown.Method();


            Console.ReadKey();
        }
    }
}
