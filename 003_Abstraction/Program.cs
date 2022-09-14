using System;
//Абстрактный класс может быть унаследован от абстрактного класса
//Реализация абстрактного метода из базового абстрактного класса в производном абстрактном классе не обязательна.


namespace _003_Abstraction
{
    //Абстрактный класс А
    abstract class AbstractClassA
    {
        public abstract void OperationA();
    }
    //Абстрактный класс В
    abstract class AbstractClassB:AbstractClassA
    {
        public abstract void OperationB();
    }
    //Конкретный класс 
    class ConcreteClass : AbstractClassB
    {
        public override void OperationA()
        {
            Console.WriteLine("ConcreteClass.OperationA");
        }
        public override void OperationB()
        {
            Console.WriteLine("ConcreteClass.OperationB");
        }
    }
    internal class Program
    {
        static void Main()
        {
            AbstractClassA instance = new ConcreteClass();
            instance.OperationA();
            //instance.OperationB(); //Почему недоступен данный метод?

            Console.ReadKey();

        }
    }
}
