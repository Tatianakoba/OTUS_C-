using System;
//Sealed методы

namespace _012_SealedMethods
{
    partial class ClassA
    {
        public virtual void Method1()
        {
            Console.WriteLine("ClassA.Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("ClassA.Method2");
        }
    }
    partial class ClassA
    {

    }
    class ClassB : ClassA
    {
        sealed public override void Method1()
        {
            Console.WriteLine("ClassB.Method1");
        }
        public override void Method2()
        {
            Console.WriteLine("ClassB.Method2");
        }
    }
    class ClassC : ClassB
    {
        //Попытка переопределить Method1 приводит к ошибке компилятора:CS0239
        //public override void Method1({Console.WriteLine("ClassC.Method1");}

        //Переопределение Method2 позволено

        public override void Method2()
        {
            
                { Console.WriteLine("ClassC.Method2"); }
        }
    }

    internal class Program
    {
        static void Main()
        {
            ClassA instanceA = new ClassA();
            
        }
    }
}
