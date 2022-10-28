using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships.UI
{
    internal class MenuUI
    {
        public static int menu()
        {
            Console.WriteLine("Choose One Option : ");
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Your Option...");
            int op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void clear()
        {
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
