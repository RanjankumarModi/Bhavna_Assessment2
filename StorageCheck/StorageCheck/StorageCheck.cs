using System;
using System.Collections.Generic;
using Assessment2_BL;

namespace StorageCheck
{
    
    class StorageCheck
    {
        public static void Main(string[] args)
        {
            Assessment2_BL.ProgrammerDetails.GetAppInfo("StorageCheck");
            Console.WriteLine("Enter any value or ? to show output");
            List<string> values = new List<string>(10);
            int i = 0;
            while (true)
            {
                Console.Write("Value: ");
                string value = Console.ReadLine();
                if (value.Equals("?"))
                {
                    Assessment2_BL.StorageCheck.PrintList(values);
                    break;
                }
                else if (values.Count < 10)
                {
                    values.Add(value);
                }
                else
                {
                    Console.WriteLine($"List is full do you want to remove an old value to add {value}? (YES/NO)");
                    if (Console.ReadLine().ToUpper().Equals("YES"))
                    {
                        if (i == 10)
                        {
                            i = 0;
                        }
                        values[i++] = value;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }        
    }
}
