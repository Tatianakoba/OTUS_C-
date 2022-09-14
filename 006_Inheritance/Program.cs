using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Приведение к базовому типу.
namespace _006_Inheritance
{
    internal class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //UpCast (Привели к базовому типу)
            BaseClass instanceUp = instance;
            instanceUp.Method();

            //DownCast
            DerivedClass instanceDown = (DerivedClass)instanceUp;
            instanceDown.Method();


            Console.ReadKey();
        }
    }
}
