using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expando_example
{
    //class Thread
    //{
    //    static void Main(string[] args)
    //    {
    //        // Main execution starts here  
    //        Console.WriteLine("Main thread starts here.");

    //        // This method takes 4 seconds to finish.  
    //      //  Program.DoSomeHeavyLifting();

    //        // This method doesn't take anytime at all.  
    //       // Program.DoSomething();

    //        // Execution ends here  
    //        Console.WriteLine("Main thread ends here.");
    //        Console.ReadKey();
    //    //}

    //public static void DoSomeHeavyLifting()
    //{
    //    Console.WriteLine("I'm lifting a truck!!");
    //    Thread.Sleep(1000);
    //    Console.WriteLine("Tired! Need a 3 sec nap.");
    //    Thread.Sleep(1000);
    //    Console.WriteLine("1....");
    //    Thread.Sleep(1000);
    //    Console.WriteLine("2....");
    //    Thread.Sleep(1000);
    //    Console.WriteLine("3....");
    //    Console.WriteLine("I'm awake.");
    //}

    //private static void Sleep(int v)
    //{
    //    throw new NotImplementedException();
    //}

    //    public static void DoSomething()
    //    {
    //        Console.WriteLine("Hey! DoSomething here!");
    //        for (int i = 0; i < 20; i++)
    //            Console.Write($"{i} ");
    //        Console.WriteLine();
    //        Console.WriteLine("I'm done.");
    //    }
    //}
    class Thread
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }
}
