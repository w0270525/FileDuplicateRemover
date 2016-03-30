//Jonathan Prince 2016-03-30
//A program designed to delete duplicate copies of the same file based on windows automatic copying format. 
//IE: file - Copy.txt, file - Copy (2).txt, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace fileduplicateremover
{
   
    class Program
    {
        //private static string directory = "C:\\Users\\princ\\Google Drive\\";

        private static string directory = @"C:\Users\princ\Google Drive\";
        static void Main(string[] args)
        {
            Console.Out.WriteLine("hello world");

            getFiles();
            Console.WriteLine("Done.");
            Console.Read();
        }

        private static void getFiles()
        {

            var dir = new DirectoryInfo(directory);


            foreach (var dirs in dir.EnumerateDirectories("*", SearchOption.AllDirectories))
            {
                foreach (var file in dirs.EnumerateFiles("*- Copy*.*"))
                {

                   
                        Console.WriteLine(dirs.FullName + "\\" + file);
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("error with file " + file);
                    }
                }


            }


        }

        private static void addListItem(string i)
        {
            throw new NotImplementedException();
        }
    }
}
