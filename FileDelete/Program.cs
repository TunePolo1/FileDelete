using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________________________________________________________________");
            Console.WriteLine("Enter path to folder...");
            string path = Console.ReadLine();
            Console.WriteLine("Enter extension (.txt, .mp3, .rar, .png)...");
            string ext = Console.ReadLine();
            ext.Trim();
            try
            {
                string[] files = Directory.GetFiles(path, "*" + ext);

                if (files.Length == 0)
                {
                    Console.WriteLine("There is no file with such an extension.");
                    Main(args);
                }
                Console.WriteLine("You are about to delete following files: ");
                foreach (string file in files)
                    Console.WriteLine(" " + file);
                Console.WriteLine("Are you sure?(y/n)");
                if (Console.ReadLine() == "y")
                {
                    foreach (string file in files)
                        File.Delete(file);
                    Console.WriteLine("Files deleted successfully");
                }
                else
                {
                    Console.WriteLine("Canceled");
                }
                Console.WriteLine("Press a to run program again or any other key to exit");
                if (Console.ReadKey().KeyChar != 'a')
                    System.Environment.Exit(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Main(args);
            }
            Main(args);

        }
    }
}
