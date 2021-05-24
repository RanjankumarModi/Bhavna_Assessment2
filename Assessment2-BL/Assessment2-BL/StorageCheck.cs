using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2_BL
{
    public static class StorageCheck
    {
        public static void PrintList(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Console.WriteLine("Values:-");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }




    }
}
