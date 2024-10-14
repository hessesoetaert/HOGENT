using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Diagnostics;
using System.Drawing;
using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 20;
            Console.WindowWidth = 20;
            Console.WriteLine("Test 1");
            Console.WriteLine("Max height: " + Console.LargestWindowHeight.ToString());
            Console.WriteLine("Max width: " + Console.LargestWindowWidth.ToString());
            Console.ReadKey();
            Console.Clear();
            Console.SetWindowSize(10, 10);
            Console.WriteLine("Test 2");
            Console.WriteLine("Max height: " + Console.LargestWindowHeight.ToString());
            Console.WriteLine("Max width: " + Console.LargestWindowWidth.ToString());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
