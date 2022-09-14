using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
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
