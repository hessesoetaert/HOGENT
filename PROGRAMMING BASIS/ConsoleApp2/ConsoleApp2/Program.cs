using System.Reflection.Metadata;
using System.Security.Principal;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de basis : ");
            double basis = double.Parse(Console.ReadLine());

            Console.Write("Geef de hoogte : ");
            double hoogte = double.Parse(Console.ReadLine());

            double schuineZijde = Math.Sqrt( Math.Pow( basis,2 ) + Math.Pow(hoogte,2) );

            string result = $"De lengte van de schuine zijde is {schuineZijde}";
            Console.WriteLine(result);


        }
    }
}
