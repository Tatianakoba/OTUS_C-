using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//самоассоциация

namespace _005_SelfAssociation
{
    internal class Program
    {
        public void Method()
        {
            Console.WriteLine("Hello world!");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Method();

            Console.ReadKey();
        }
    }
}
