using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Констукторы
namespace Classes
{
    class Point
    {
        //Поля
        private int x,y;
        //Свойства
        public int X
            {get { return x; } }
        public int Y 
        { get { return y; } }
        //Конструктор по умолчанию, инициализирует поля значениями по умолчанию
        public Point()
        {
            Console.WriteLine("Конструктор по умолчанию!");
        }
        //Пользовательский конструктор, инициализирует поля, значениями заданными пользователями
        public Point(int x, int y)
        {
            Console.WriteLine("Пользовательский конструктор!");
            this.x = x;
            this.y = y;

        }
    }
}
