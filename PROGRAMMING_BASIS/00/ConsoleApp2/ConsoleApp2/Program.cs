using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rnd = 2;
            bool isEven = false;
            int streak = 0;

            ConsoleKey keyPressed = Console.ReadKey().Key;
            if (keyPressed == ConsoleKey.Enter)
            {
                Console.WriteLine("ENTER");
            }

            bool doLoop = true;


            while (doLoop)
            {

                do
                {
                    Console.WriteLine("\nDo again?: [y/n] \n");
                    keyPressed = Console.ReadKey().Key;
                    if (keyPressed == ConsoleKey.Y)
                    {
                        doLoop = true;
                    }
                    else if (keyPressed == ConsoleKey.N)
                    {
                        doLoop =false;
                    }
                } while (keyPressed != ConsoleKey.Y || keyPressed != ConsoleKey.N);

            }




        }
    }
}
