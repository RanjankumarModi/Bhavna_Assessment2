using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2_BL
{
    public static class CalculateNoOfDays
    {
       
        //public static int CalculateTotalDay(DateTime fromDate, DateTime toDate)
        //{
        //    return(toDate.Subtract(fromDate).Days);
        //}
        //public static int CalculateTotalMonth(DateTime fromDate, DateTime toDate)
        //{
        //    return ((toDate.Month - fromDate.Month + (toDate.Year - fromDate.Year) * 12));
        //}
        //public static int CalculateTotalYear(DateTime fromDate, DateTime toDate)
        //{
        //    return (toDate.Year - fromDate.Year);
        //}

        public static List<int> CalculateDateDifference(int day1, int mon1,int  year1,int  day2,int  mon2,int  year2)
        {
            
            
           
            if (day2 < day1)
            {
                // borrow days from february
                if (mon2 == 3)
                {
                    //  check whether year is a leap year
                    if ((year2 % 4 == 0 && year2 % 100 != 0) || (year2 % 400 == 0))
                    {
                        day2 += 29;
                    }

                    else
                    {
                        day2 += 28;
                    }
                }

                // borrow days from April or June or September or November
                else if (mon2 == 5 || mon2 == 7 || mon2 == 10 || mon2 == 12)
                {
                    day2 += 30;
                }

                // borrow days from Jan or Mar or May or July or Aug or Oct or Dec
                else
                {
                    day2 += 31;
                }

                mon2 = mon2 - 1;
               // Console.WriteLine(year2 + "  y  " + year1);
            }

            if (mon2 < mon1)
            {
                mon2 += 12;
                year2 -= 1;
               // Console.WriteLine(year2 + "  y  " + year1);
            }
           List<int> date = new List<int>();
          date.Add(day2 - day1);
           date.Add( mon2 - mon1);

            //Console.WriteLine(year2+"  y  "+year1);
          date.Add( year2 - year1);


            return date;
        }





    }
}
