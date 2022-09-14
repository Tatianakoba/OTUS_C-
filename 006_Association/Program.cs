using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//использование техники фабричных методов
namespace _006_Association
{
    class Product
    {
        public Product()
        {
            Console.WriteLine("Создан экземпляр класса Product");
        }
    }
    class Factory
    {
        public Product FactoryMethod()
        {
            return new Product();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Product product = factory.FactoryMethod();  

            Console.ReadKey();
        }
    }
}
