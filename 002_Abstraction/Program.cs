using System;


namespace _002_Abstraction
{
    //Конкретный класс А
    class ConcreteClassA
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteClassA.Operation");
        }
    }
    //Абстрактный класс
    abstract class AbstractClass : ConcreteClassA
    {
        public abstract void Method();
    }
    //Конкретный класс B
    class ConcreteClassB : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteClassB.Method");
        }
    }
    internal class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClassB();
            instance.Method();
            instance.Operation();

            Console.ReadKey();
        }
    }
}
