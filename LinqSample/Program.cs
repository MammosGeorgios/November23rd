using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\windows";
            ShowLargeFilesWithoutLinq(path);
            Console.WriteLine("================================================================");

            ShowLargeFilesWithLinq(path);
            Console.WriteLine("================================================================");


            string test = "40,5";
            double test1 = test.ToDouble() + 1 ;
            Console.WriteLine(test1);
            Console.WriteLine("================================================================");





        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;

            foreach(var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-30} : {file.Length}");
            }
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer()) ;
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine($"{file.Name,-30} : {file.Length}");
            //}

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name,-30} : {file.Length}");
            }
        }

        internal class FileInfoComparer : IComparer<FileInfo>
        {
            public FileInfoComparer()
            {

            }
            public int Compare(FileInfo x , FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }
        
    }
}
