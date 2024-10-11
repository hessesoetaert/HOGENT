using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        public static string g_elapsedMSec = " START";
        public static Stopwatch g_runTime = new Stopwatch();
        public static int g_frameNr = 0;
        

        static void Main(string[] args)
        {

            bool runGame = true;
            g_runTime.Start();








            ConsoleSpiner spin = new ConsoleSpiner();
            Console.Write("Working....\n");
            double elapsedTime = 0;
            while (runGame)
            {
                elapsedTime += Program.GetElapsedSec();
                //if ()
                {
                    spin.Turn();
                }


                //ELAPSED SEC
                g_runTime.Stop();
                g_elapsedMSec = g_runTime.ElapsedMilliseconds.ToString();
                g_runTime.Restart();
            }
        }

        
        public void GameLoop()
        {

        }

        public void DrawFrame(double elapsedTime = 0)
        {

        }

        double GetElapsedSec()
        {
           double elapsedSec = double.Parse(g_elapsedMSec) * 1000;
            
            return elapsedSec ;
        }


        public class ConsoleSpiner
        {
            int counter;
            public ConsoleSpiner()
            {
                counter = 0;
            }
            public void Turn()
            {
                counter++;
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
}
