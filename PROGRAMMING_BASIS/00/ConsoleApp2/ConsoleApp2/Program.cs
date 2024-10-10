using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleKey keyPressed;
            Console.WriteLine("press enter");
            
            bool isValidKey = true;
            do
            {
                keyPressed = Console.ReadKey().Key;

                if (keyPressed == ConsoleKey.Enter)
                {
                    isValidKey = true;
                    Console.WriteLine("ENTER");

                }
                else
                {
                    isValidKey = false;
                }
            } while (isValidKey);
            

            keyPressed = Console.ReadKey().Key;
            if (keyPressed == ConsoleKey.Enter)
            {
                
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
                        isValidKey = true;

                    }
                    else if (keyPressed == ConsoleKey.N)
                    {
                        doLoop =false;
                        isValidKey = true;
                    }
                    else
                    {
                        isValidKey = false;
                    }
                } while (isValidKey);

            }




        }
    }
}
