using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2_BL
{
    public static class ProgrammerDetails
    {
        public static void GetAppInfo(string appName)
        {
            string appVersion = "1.0.0";
            string author = "Ranjan Kumar";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{appName}: Version {appVersion} by {author}");
            Console.ResetColor();
        }
    }
}
