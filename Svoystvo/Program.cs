using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//классы (Использование свойств, для доступа к закрытым полям)
//Свойство - интерфейс доступа к полю объекта
//Свойства в C# - поля с логическим блоком, в котором есть ключевые слова get и set
// и являются суррогатом для замены методов доступа к полю.
//при обращении к свойству вызывается определенный метод, который выполняет определенные операции с объектом

namespace Svoystvo
{
    class MyClass
    {
        private string field = null;
        public string Field //открытое строковое свойствос именем Field
        {
            set //void SetField(string value) - setter
            { 
                field = value; 
            }
            get //string GetField() - getter
            { 
                return field; 
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Field = "Hello World!!!"; //Метод-мутатор
            Console.WriteLine(instance.Field); //Метод-аксессор
            Console.ReadKey();
        }
    }
}
