using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ItemsDatFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string gtpath = @"\AppData\Local\Growtopia";
            string cpg = cuser + gtpath;
            string desktop = cuser + @"\Desktop";

            Console.WriteLine("ItemsDatFinder (C) GuckTube YT");
            Console.WriteLine("This app is for finding items.dat");
            Console.WriteLine("When this app Get the items.dat");
            Console.WriteLine("It's Automatic put on Desktop\n");
            Console.Write("Press Enter to Start...");
            Console.ReadLine();
            if (File.Exists(cpg + @"\cache\items.dat"))
            {
                Console.WriteLine("\nitems.dat found! Moving to desktop...");
                File.Move(cpg + @"\cache\items.dat", desktop + @"\items.dat");
                Console.WriteLine("\nitems.dat has been moved into Desktop!");
                Console.WriteLine("Press any key to Quit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.Write("\nitems.dat not found! Please play growtopia first");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
