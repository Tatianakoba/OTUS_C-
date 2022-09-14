using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//использование свойств для доступа к закрытым полям
namespace _004_Properties
{
    class MyClass
    {
        private string field = null;
        public string Field //открытое строковое свойствос именем Field
        {
            set //void SetField(string value) - setter
            {
                if (value == "Goodbye")
                    Console.WriteLine("Вы ввели недопустимое значение. Повторите попытку");
                else
                    field = value;
            }
            get //string GetField() - getter
            {
                if (field == null)
                    return "В поле отсутствуют данные";
                else if (field == "hello world")
                    return field.ToUpper()+"!";
                else
                    return field;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Field = "Goodbye";
            Console.WriteLine(instance.Field);
            Console.WriteLine(new string('-', 50));

            instance.Field = "hello world";
            Console.WriteLine(instance.Field);
            Console.ReadKey();
        }
    }
}
