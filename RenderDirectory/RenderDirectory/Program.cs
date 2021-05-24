using System;
using System.IO;


namespace RenderDirection
{
    class Program
    {
        public static void Main(String[] agr)
        {
            Console.WriteLine("Enter Directory Path:");
            DirectoryInfo userDirectory=null;
            try
            {
                userDirectory = new DirectoryInfo(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured:{0}", e.Message);
                Console.Write("Enter valid directory path:");
                userDirectory = new DirectoryInfo(Console.ReadLine());
                Console.WriteLine();
            }
            finally
            {
                while (!userDirectory.Exists)
                {
                    Console.WriteLine("Given Path Doesn't Exits");
                    Console.Write("Enter valid directory path:");
                    userDirectory = new DirectoryInfo(Console.ReadLine());
                    Console.WriteLine();
                }
            }
              Assessment2_BL.DirectoryTree.PrintTree(userDirectory);
            foreach(string str in Assessment2_BL.DirectoryTree.List)
            {
                Console.WriteLine(str);
            }
        }
    }
}