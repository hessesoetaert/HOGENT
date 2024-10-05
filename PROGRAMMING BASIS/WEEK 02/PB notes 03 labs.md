## String interpolatie

#### oefening D03frietjesinterpolatie
oops als gedaan
[[PB notes 02 labs#oefening D02frietjes]]

#### oefening D03leeftijdinterpolatie
[[PB notes 02 labs#oefening D02leeftijd]]
#### oefening D03sominterpolatie
[[PB notes 02 labs#oefening D02som]]

## Werken met getallen
#### oefening D03getalraden
```C# title:D03getalraden
Random rnd = new Random();

Console.WriteLine("De computer denkt aan een getal tussen 0 en 10.");
int randomGetal = rnd.Next(0,10);

Console.Write("Welk getal denkt u dat het is : ");
int geradenGetal = int.Parse(Console.ReadLine());

if (randomGetal == geradenGetal)
{
	Console.WriteLine("Proficiat, u heeft goed geraden!");
}
else
{
	Console.WriteLine($"Helaas, het getal was {randomGetal}!");
}
```
#### oefening D03kleinermetif
```c# title:D03kleinermetif
Console.Write("Geef een getal : ");
int getal1 = int.Parse(Console.ReadLine());

Console.Write("Geef een ander getal : ");
int getal2 = int.Parse(Console.ReadLine());
while (getal1 == getal2)
{
	Console.Write("Geef een ANDER getal : ");
	getal2 = int.Parse(Console.ReadLine());
}

int kleinsteGetal;
if (getal1 < getal2)
{
	kleinsteGetal = getal1;
}
else
{
	kleinsteGetal = getal2;
}
Console.WriteLine($"{kleinsteGetal} is kleiner.");
```
#### oefening D03kleinermathmin
```C# title:D03kleinermathmin
Console.Write("Geef een getal : ");
int getal1 = int.Parse(Console.ReadLine());

Console.Write("Geef een ander getal : ");
int getal2 = int.Parse(Console.ReadLine());
while (getal1 == getal2)
{
	Console.Write("Geef een ANDER getal : ");
	getal2 = int.Parse(Console.ReadLine());
}

int kleinsteGetal = Math.Min(getal1, getal2);

Console.WriteLine($"{kleinsteGetal} is kleiner.");
```
#### oefening D03cirkel
```C# title:D03cirkel
Console.Write("Geef de straal van een cirkel : ");
double straal = double.Parse(Console.ReadLine());

double omtrek = 2 * Math.PI * straal;
double oppervlakte = Math.PI * Math.Pow(straal,2);

string result = $"De omtrek is {omtrek} en de oppervlakte is {oppervlakte}.";
Console.WriteLine(result);
```
#### oefening D03pythagoras
```C# title:D03pythagoras
Console.Write("Geef de basis : ");
double basis = double.Parse(Console.ReadLine());

Console.Write("Geef de hoogte : ");
double hoogte = double.Parse(Console.ReadLine());

double schuineZijde = Math.Sqrt( Math.Pow( basis,2 ) + Math.Pow(hoogte,2) );

string result = $"De lengte van de schuine zijde is {schuineZijde}";
Console.WriteLine(result);
```
#### oefening D03absolutewaarde
```C# title:D03absolutewaarde
Console.Write("Geef een getal : ");
int getal = int.Parse(Console.ReadLine());

int absoluteWaarde = Math.Abs(getal);

Console.WriteLine($"de absolute waarde is : {absoluteWaarde}");
```

## Variabelen en scope
#### oefening D03imperial
```C# title:D03imperial
const double ftToCm = 30.48;
const double inchtoCm = 2.54;


Console.Write("Geef het aantal feet : ");
string aantalFeetAlsTekst = Console.ReadLine();
double aantalFeet = double.Parse(aantalFeetAlsTekst);

Console.Write("Geef het aantal inches : ");
string aantalInchesAlsTekst = Console.ReadLine();
double aantalInches = double.Parse(aantalInchesAlsTekst);

double aantalFeetInCm = aantalFeet * ftToCm;
double aantalInchesInCm = aantalInches * inchtoCm;

double totaalInCm = aantalFeetInCm + aantalInchesInCm;

Console.WriteLine($"Dat is {totaalInCm}cm.");
```
#### oefening D03persecondewijzer
```C# title:D03persecondewijzer

```

## Traceertabellen
#### oefening D03
```C# title:

```
#### oefening D03
```C# title:

```
#### oefening D03
```C# title:

```
#### oefening D03
```C# title:

```
