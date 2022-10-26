using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class MyFactory<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    public class MyType
    {
        public int a;

        public MyType(int a)
        {
            this.a = a;
        }

        public class MyClass
        {
            public int Val { get; set; }
            public MyClass(int i)
            {
                Val = i;
            }
            public MyClass() { }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            var instance = MyFactory<MyType>.FacrotyMethod();

            Console.WriteLine(instance.GetType());
            Console.ReadKey();
        }
    }
}
