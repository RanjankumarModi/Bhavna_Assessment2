using System;
using System.Collections.Generic;

namespace DaysCalculator
{
    
    class Program
    {
        #region Main Method 
        /// <summary>
        /// main Method that takes two date as input
        /// check all condition as well as implement Exception handling
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DateTime toDate , fromDate;
           // CalculateNoOfDays calculateNoOfDays = new CalculateNoOfDays();
            Console.WriteLine("Input Formate must be DD-MM-YYYY");
            Console.WriteLine("Please Enter the Dates");
            Console.Write("From : ");
            var isValidDate = DateTime.TryParse(Console.ReadLine(), out fromDate);

            while(!isValidDate|| fromDate >= DateTime.Now)
            {
                Console.WriteLine("Error Occured: Formate Wrong/ Future Date");
                Console.Write("From : ");
                isValidDate = DateTime.TryParse(Console.ReadLine(), out fromDate);
            }

            Console.Write("To : ");
            isValidDate = DateTime.TryParse(Console.ReadLine(), out toDate);
            while (!isValidDate || toDate < fromDate)
            {
                Console.WriteLine("Error Occured: Formate Wrong/ toDate may be less than fromdate");
                Console.Write("From : ");
                isValidDate = DateTime.TryParse(Console.ReadLine(), out toDate);
            }
            // List<int> listDate = new List<int>(3);
            //DateTime f = DateTime.Parse(fromDate);
            //try
            //{
            //    Assessment2_BL.CalculateNoOfDays.CalculateDateDifference(fromDate, toDate);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Error Found", e.Message);
            //}

            // Console.WriteLine("{0} day {1} Month and {2} year",listDate[0], listDate[1], listDate[2]);
            int day1, mon1, year1;
            int day2, mon2, year2;
            day1 = fromDate.Day;
            mon1 = fromDate.Month;
            year1 = fromDate.Year;
            day2 = toDate.Day;
            mon2 = toDate.Month;
            year2 = toDate.Year;

           var result= Assessment2_BL.CalculateNoOfDays.CalculateDateDifference(day1, mon1, year1, day2, mon2, year2);
            Console.WriteLine("Days:{0} ", toDate.Subtract(fromDate).Days);
            Console.WriteLine("Days:{0} Month:{1} ",result[0], (mon2 -mon1 + (year2 - year1) * 12));
            Console.WriteLine("Days:{0} Month:{1} and year:{2}", result[0], result[1],result[2]);
        }
        #endregion 
    }
}
