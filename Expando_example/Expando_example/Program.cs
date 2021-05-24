//using System;
//using System.Dynamic;

//namespace Expando_example
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            dynamic Object1 = new ExpandoObject();
//            //Object1.String = "My name is ranjan";

//            //Console.WriteLine(Object1.String);
//            //Console.WriteLine(Object1.String.GetType());
//            //Console.ReadLine();
//            Object1.number = 10;
//            Object1.Multiply = (Action)(() => { Object1.number++; });
//            Console.WriteLine(Object1.number);
//            Object1.Multiply();
//            Console.WriteLine(Object1.number);
//            Console.ReadLine();
//        }
//    }
//}
