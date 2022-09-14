using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//поля только для чтения
namespace _004_Readonly
{
    internal class Program
    {
        //поле только для чтения(устанавливается только конструктором)!
        public readonly string field = "Hello";
        //конструктор
        public Program()
        {
            field = "Поле только для чтения";
            field += "!";
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.field);

            //ошибка компиляции
            //program.field - "Попытка записи в поле только для чтения";

            Console.ReadKey();
        }
    }
}
