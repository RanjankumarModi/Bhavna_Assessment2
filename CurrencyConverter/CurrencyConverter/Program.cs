//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using ConsoleApp1;

//namespace CurrencyConverter
//{
//    class conversionlist
//    {
//        private string currencyname;
//        private float exchangevalue;

//        public conversionlist(string currencyname, float exchangevalue)
//        {
//            currencyname1 = currencyname;
//            exchangevalue1 = exchangevalue;
//        }

//        public string currencyname1 { get => currencyname; set => currencyname = value; }
//        public float exchangevalue1 { get => exchangevalue; set => exchangevalue = value; }
//    }

//    class Program
//    {

//        #region Main Method
//        /// <summary>
//        /// Main Method contains option for user
//        /// </summary>
//        /// <param name="args"></param>
//        static void Main(string[] args)
//        {
//            Console.WriteLine(ConsoleApp1.Program.Get());
//           List<ConversionList> list = new List<ConversionList>();
//            DataBase db = new DataBase();
//            //db.CreateTable();
//            bool choice;
//            Console.WriteLine("Welcome To Currency Converter ");
//            Console.WriteLine("Enter 5 Currency Name and its Value against the Indian Rupee ");
//            Console.WriteLine("----------------------------");
//            db.Insert("EUR", 24);
//            db.Insert("USD", 45);
//            db.Insert("CAD", 50);
//            db.Insert("MYR", 100);
//            db.Insert("JPY", 150);
//            Console.WriteLine("----------------------------");

//            do
//            {
//                Console.Write("Do you want to continue with the Existing List(yes/no): ");
//                string userChoice = Console.ReadLine();

//                if (userChoice.ToLower() == "yes")
//                {
//                    //float rupee = float.MinValue;
//                    Console.WriteLine("----------------------------");
//                    Console.Write("Enter the Foeign Currency Symbol  :");
//                    string currencySymbol = Console.ReadLine();

//                    Console.Write("Enter the amount In foreign Currency:");
//                    float currencyValue = int.Parse(Console.ReadLine());
//                     db.SearchCurrency(currencySymbol, currencyValue);
//                    Console.WriteLine("----------------------------");
//                }
//                else
//                {
//                    db.Delete();
//                    Console.WriteLine("Enter the Number of Currency Name and value you want to enter");
//                    Console.WriteLine("----------------------------");

//                    int iterable = int.Parse(Console.ReadLine());

//                    for (int i = 0; i <iterable; i++)
//                    {
//                        Console.Write("Enter the {0} Currency Name: ", i + 1);
//                        string name = Console.ReadLine();
//                        Console.Write("Enter the {0} Currency Exchange Value: ", i + 1);
//                        float value = float.Parse(Console.ReadLine());
//                        db.Insert(name, value);
//                    }
//                    Console.WriteLine("----------------------------");
//                    Console.WriteLine("Now Enter the data to be Calculated");
//                   // float rupee = float.MinValue;
//                    Console.Write("Enter the Foeign Currency Symbol :");
//                    string currencySymbol = Console.ReadLine();

//                    Console.Write("Enter the Foeign Currency Value:");
//                    float currencyValue = int.Parse(Console.ReadLine());
//                     db.SearchCurrency(currencySymbol, currencyValue);
//                    Console.WriteLine("----------------------------");
//                }
//                Console.Write("Do you want to Use again(true/false)");
//                choice = bool.Parse(Console.ReadLine().ToLower());
//            } while (choice);


//        }

//        private class ConversionList
//        {
//        }
//        #endregion
//    }

//}

using System;
using System.Collections.Generic;
using ConsoleApp1;
using currencyconverter;

namespace CurrencyConverter
{
    public class Program
    {
        
    }
}
