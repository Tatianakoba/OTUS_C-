using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Properties
{
    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.71D;
        //Свойство только для записи - WriteOnly Property
        public double Pi
        {
            set { pi = value; }
        }
        //Свойство только для чтения - ReadOnly Property
        public double E
        {
            get { return e; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Constants constants = new Constants();
            constants.Pi = 3.14159265D;
            //Console.Writeline(constants.Pi); // Недопустимо.
            //constants.E = 3.71D; //Недопустимо.
            Console.WriteLine("e = {0}", constants.E);
            Console.ReadKey();

        }
    }
}
