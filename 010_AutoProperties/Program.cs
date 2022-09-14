using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//автоматически реализуемые свойства (Auto-Implemented properties). Это более лаконичная форма свойств, их есть смысл использовать,
//когда в методах доступа (get и set) не требуется дополнительная логика.
//При создании автоматически реализуемых свойств, компилятор создаст закрытое, анонимное резервное поле,
//которое будет доступно с помощью методов get и set свойства.
namespace _010_AutoProperties
{
    internal class Program

    {
        public class Author
        { 
            //Автоматически реализуемые свойства
            public string Name 
            { 
                get { return name; }
                set
                { 
                    if (value != "fool")
                        Name = value;
                }
            }
            public string Book { get; set; }
        }
        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                Name = "Jeffrey Richter", //Блок инициализатора
                Book = "CLR via C#"
            };
            Author author2 = new Author     //() - можем опустить скобки
            {
                Name = "Steve McConnell",
                Book = "Code Complete"
             };

            Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

            Console.ReadKey();

        }
    }
}
