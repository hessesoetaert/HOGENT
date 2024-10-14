using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;



namespace ConsoleApp1
{
    internal class Program
    {
        // Structure used by GetWindowRect
        struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        static Stopwatch g_runTime = new Stopwatch();

        static int g_frameNr = 0;
        static bool g_runGame = true;
        static string g_elapsedSec = g_runTime.Elapsed.ToString();

        static void Main(string[] args)
        {
            Console.SetWindowSize(55, 10);
            Console.SetWindowPosition(0, 0);
            Console.SetBufferSize(Int16.MaxValue - 1, Int16.MaxValue - 1);
            Console.CursorVisible = false;
            //Console.SetWindowSize(55, 55);
            g_runTime.Start();

            int size = 40;

            ConsoleRectangle rect = new ConsoleRectangle(size, size, new Point(0, 0), ConsoleColor.White);

            rect.Draw();

            ConsoleSpiner spin = new ConsoleSpiner();
            Console.Write("Working....\n");

            double elapsedTime = 0;
            double interval = 0.1;

            Console.WriteLine($"width: {Console.BufferWidth}, height: {Console.BufferHeight}");

            while (g_runGame)
            {
                Update(GetElapsedSec());
                Draw();



                UpdateElapsedSec();
            }



            //=============================================================================================

            void Update(double elapsedSec = 0)
            {
                elapsedTime += GetElapsedSec();
                if (elapsedTime >= (interval))
                {
                    spin.Turn();
                    elapsedTime = 0;
                }
            }

            double GetElapsedSec()
            {

                double elapsedSec = (double.Parse(g_elapsedSec.Substring(6)));

                return elapsedSec;
            }

            void Draw()
            {

            }

            void UpdateElapsedSec()
            {
                g_runTime.Stop();
                g_elapsedSec = g_runTime.Elapsed.ToString();
                //Console.WriteLine(g_elapsedSec);
                g_runTime.Restart();
            }

            void SetFullScreen()
            {
                // Import the necessary functions from user32.dll
                [DllImport("user32.dll")]
                static extern IntPtr GetForegroundWindow();
                [DllImport("user32.dll")]
                static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
                [DllImport("user32.dll")]
                static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);
                [DllImport("user32.dll")]
                static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool bRepaint);
                // Constants for the ShowWindow function
                const int SW_MAXIMIZE = 3;
                // Get the handle of the console window
                IntPtr consoleWindowHandle = GetForegroundWindow();
                // Maximize the console window
                ShowWindow(consoleWindowHandle, SW_MAXIMIZE);
                // Get the screen size
                Rect screenRect;
                GetWindowRect(consoleWindowHandle, out screenRect);
                // Resize and reposition the console window to fill the screen
                int width = screenRect.Right - screenRect.Left;
                int height = screenRect.Bottom - screenRect.Top;
                MoveWindow(consoleWindowHandle, screenRect.Left, screenRect.Top, width, height, true);
            }
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        public class ConsoleRectangle
        {
            private int hWidth;
            private int hHeight;
            private Point hLocation;
            private ConsoleColor hBorderColor;

            public ConsoleRectangle(int width, int height, Point location, ConsoleColor borderColor)
            {
                hWidth = width;
                hHeight = height;
                hLocation = location;
                hBorderColor = borderColor;
            }

            public Point Location
            {
                get { return hLocation; }
                set { hLocation = value; }
            }

            public int Width
            {
                get { return hWidth; }
                set { hWidth = value; }
            }

            public int Height
            {
                get { return hHeight; }
                set { hHeight = value; }
            }

            public ConsoleColor BorderColor
            {
                get { return hBorderColor; }
                set { hBorderColor = value; }
            }

            public void Draw()
            {
                string s = "╔";
                string space = "";
                string temp = "";
                for (int i = 0; i < Width; i++)
                {
                    space += " ";
                    s += "═";
                }

                for (int j = 0; j < Location.X; j++)
                    temp += " ";

                s += "╗" + "\n";

                for (int i = 0; i < Height; i++)
                    s += temp + "║" + space + "║" + "\n";

                s += temp + "╚";
                for (int i = 0; i < Width; i++)
                    s += "═";

                s += "╝" + "\n";

                Console.ForegroundColor = BorderColor;
                Console.CursorTop = hLocation.Y;
                Console.CursorLeft = hLocation.X;
                Console.Write(s);
                Console.ResetColor();
            }
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
