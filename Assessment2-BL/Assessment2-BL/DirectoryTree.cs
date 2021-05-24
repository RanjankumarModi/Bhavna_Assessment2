using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assessment2_BL
{
    public static class DirectoryTree
    {
        private static List<string> _List = new List<string>();

        public static List<string> List { get => _List; set => _List = value; }

        public static void PrintTree(DirectoryInfo root)
        {
            
            string Space = " ";
            FileInfo[] files = null;
            DirectoryInfo[] subDirs;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (var f1 in files)
                {

                    List.Add(Space + "-" + f1.Name);
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    List.Add(Space + "--" + dirInfo.Name);
                    Space = Space + " ";
                    PrintTree(dirInfo);
                    Space += " ";
                }
            }
            
        }
    }
}
