using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//наследование
namespace Inheritance
{
    class DerivedClass: BaseClass
    {
        //конструктоор
        public DerivedClass()
        {
            //изменяем все доступные поля унаследованые
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
    }
}
