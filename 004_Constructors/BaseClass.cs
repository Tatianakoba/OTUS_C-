using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Constructors
{
    class BaseClass

    {
        public int baseNumber;
        //конструктор по умолчанию
        public BaseClass()
        {

        }
        //пользовательский конструктор
        public BaseClass(int number)
        {
            this.baseNumber = number;
        }

    }
}
