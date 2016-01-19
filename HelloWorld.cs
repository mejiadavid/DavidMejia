using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string x= "0";
            
            Console.WriteLine("\n\n\nDavid Mejia");
            x = Console.ReadLine();
            if (x == "1")
            {
                Console.WriteLine("If is working");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("If is NOT working or you did not input the correct value!");
                Console.ReadLine();
            }
            int y =0;
            Console.BackgroundColor = ConsoleColor.White;
            while (y < 20)
            {
                y++;
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
