using System;
using System.Collections.Generic;

namespace Currency
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            List<Assessment2_BL.ConversionList> currencies = new List<Assessment2_BL.ConversionList>();
             currencies = Assessment2_BL.CurrencyConvertBL.GetlistFromDatabase(); 

            if (currencies.Count == 0)
            {
                Console.WriteLine("Enter Currency names and conversion rates:-");
                Assessment2_BL.CurrencyConvertBL.AddCurrencies();
                currencies = Assessment2_BL.CurrencyConvertBL.GetlistFromDatabase();
            }
            else
            {
                Console.WriteLine("Do want to add new Conversion rates? (YES/NO)");
                if (Console.ReadLine().ToUpper().Equals("YES"))
                {
                    Assessment2_BL.CurrencyConvertBL.DeleteCurrenciesFromDatabase();
                    Console.WriteLine("Enter Currency names and conversion rates:");
                    //AddCurrencies();
                    currencies = Assessment2_BL.CurrencyConvertBL.GetlistFromDatabase();
                }
            }
            float x = Assessment2_BL.CurrencyConvertBL.CalculateCurrency();
        }
    }
}
