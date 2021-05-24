using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessment2_BL;

namespace CapitalizeFirstLetter
{
    class Class1
    {
        public static void Main(string[] args)
       {

            
           // CapitalizeFirscapitalizeFirstLetter = new CapitalizeFirstLetter();
            Console.Write("Enter a string: ");
            string sentence=Console.ReadLine();
            //Console.WriteLine(sentence.Length);
            while (String.IsNullOrEmpty(sentence))
            {
                Console.Write("Please enter a valid amount: ");
                 sentence = Console.ReadLine();
            }
            Console.WriteLine("----------------------");
            Console.WriteLine(Assessment2_BL.CapitalizeFirstLetter.Check(sentence.Trim()));

        }
    }
}
