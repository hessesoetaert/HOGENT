using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        { 



            const int secondenPerMinuut = 60;
            const int secondenPerUur = 60 * secondenPerMinuut;

            Console.Write("Geef het totaal aantal seconden : ");
            string totaalSecondenAlsTekst = Console.ReadLine();
            int totaalSeconden = int.Parse(totaalSecondenAlsTekst);
            
            int resterendeSeconden = totaalSeconden;
            int uren = resterendeSeconden / secondenPerUur;
            resterendeSeconden = resterendeSeconden - uren * secondenPerUur;
            
            int minuten = resterendeSeconden / secondenPerMinuut;
            resterendeSeconden = resterendeSeconden - minuten * secondenPerMinuut;
            
            int seconden = resterendeSeconden;
            
            Console.WriteLine($"{totaalSeconden}s is {uren}u, {minuten}min en {seconden}s.");



        }
    }
}
