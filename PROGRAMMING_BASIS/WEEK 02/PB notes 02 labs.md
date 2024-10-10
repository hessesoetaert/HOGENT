## String concatenatie en input/output
#### oefening D02frietjes
```c# title:D02frietjes
// vraag naam 1
Console.Write("Geef een naam : ");
string naam1 = Console.ReadLine();
//vraag naam 2
Console.Write("Geef nog een naam : ");
string naam2 = Console.ReadLine();

//vraag een gerecht
Console.Write("Geef een gerecht : ");
string gerecht = Console.ReadLine();

//result
string result = $"{naam1} en {naam2} eten graag {gerecht}.";
Console.WriteLine(result);
```

#### oefening D02leeftijd
```c# title:D02leeftijd
// vraag naam 
Console.Write("Geef je naam : ");
string naam = Console.ReadLine();
//vraag leeftijd
Console.Write("Geef je leeftijd : ");
int leeftijd = int.Parse(Console.ReadLine());


//result
string result = $"Goeiedag {naam}, je bent dus {leeftijd} jaar oud!";
Console.WriteLine(result);
```

## Conversie
#### oefening D02leeftijdvolgendjaar
```c# title:D02leeftijdvolgend jaar
// vraag naam 
Console.Write("Geef je naam : ");
string naam = Console.ReadLine();
//vraag leeftijd
Console.Write("Geef je leeftijd : ");
int leeftijd = int.Parse(Console.ReadLine());

//leeftijd volgend jaar
int leeftijdVolgendJaar = leeftijd + 1;

//result
string result = $"Oei oei {naam}, volgend jaar ben je al {leeftijdVolgendJaar} jaar oud!";
Console.WriteLine(result);
```

#### oefening D02som
```C# title:D02som
// vraag muntstukken van 2 
Console.Write("Aantal muntstukken van 2 euro : ");
int muntstukkenVan2 = int.Parse(Console.ReadLine());

//vraag muntstukken van 1
Console.Write("Aantal muntstukken van 1 euro : ");
int muntstukkenVan1 = int.Parse(Console.ReadLine());

//result
int totaalBedrag = muntstukkenVan1 + muntstukkenVan2 * 2;
string result = $"Het totale bedrag is {totaalBedrag} Euro.";
Console.WriteLine(result);
```

#### oefening D02gemiddelde
```C# title:D02gemiddelde
// vraag kommagetallen
Console.Write("geef een kommagetal : ");
double getal1 = double.Parse(Console.ReadLine());
Console.Write("geef nog een kommagetal : ");
double getal2 = double.Parse(Console.ReadLine());
Console.Write("geef nog een kommagetal : ");
double getal3 = double.Parse(Console.ReadLine());

//result
double gemmidelde = (getal1 + getal2 + getal3) / 3;
string result = $"Het gemiddelde van {getal1}, {getal2} en {getal3} is {gemmidelde}";
Console.WriteLine(result);
```

#### oefening D02temperatuur
```C# title:D02temperatuur
// vraag var
Console.Write("geef een temperatuur in graden Fahrenheit : ");
double tempInF = double.Parse(Console.ReadLine());


//result
double tempInC = (5.0 / 9.0) * (tempInF - 32.0);
string result = $"Dit is {tempInC} graden Celcius.";
Console.WriteLine(result);
```

#### oefening D02getalontleden
```C#: title:D02getalontleden
// vraag var
Console.Write("geef een getal : ");
int getal = int.Parse(Console.ReadLine());


//result
int hondertallen = (getal/100) % 10;
int tientallen = (getal / 10) % 10;
int eenheden = getal % 10;

string result = $"Het getal {getal} bestaat uit\r\n" +
	$"{hondertallen} x 100\r\n" +
	$"{tientallen} x  10\r\n" +
	$"{eenheden} x   1";

Console.WriteLine(result);
```

#### oefening D02hetmaandieet
```C# title:D02hetmaandieet
// vraag var
Console.Write("Geef je gewicht in kg : ");
double gewichtOpAarde = double.Parse(Console.ReadLine());


//result
double gewichtOpMaan = gewichtOpAarde / 6;

string result = $"Op de maan zou je ongeveer {gewichtOpMaan} kg wegen.";
Console.WriteLine(result);
```

## Controlestructuren if en if/else
#### oefening D02volwassen
```C# title:D02volwassen
// vraag var
Console.Write("Geef je leeftijd : ");
int leeftijd = int.Parse(Console.ReadLine());
string result;

if (leeftijd >= 18)
{
	result = "Je bent wel volwassen.";
}
else
{
	result = "Je bent niet volwassen.";
}
Console.WriteLine(result);
```

#### oefening D02gelijk
```C# title:D02gelijk
// vraag var
Console.Write("Geef een geheel getal : ");
int getal1 = int.Parse(Console.ReadLine());

Console.Write("Geef nog een geheel getal : ");
int getal2 = int.Parse(Console.ReadLine());

string result;

if (getal1 == getal2)
{
	result = "Ze zijn gelijk.";
}
else
{
	result = "Ze zijn verschillend.";
}
Console.WriteLine(result);
```

#### oefening D02quotient
```C# title:D02quotient
// vraag var
Console.Write("Deeltal?: ");
double deeltal = double.Parse(Console.ReadLine());

Console.Write("Deler?: ");
double deler = double.Parse(Console.ReadLine());

//loop until not 0
while (deler == 0)
{
	Console.WriteLine("Deling door nul wordt niet toegelaten.");
	Console.Write("Deler?: ");
	deler = double.Parse(Console.ReadLine());
}

//result
double quotient = deeltal / deler;
string result = $"Quotient: {quotient}";
Console.WriteLine(result);
```
#### oefening D02even
```C# title:D02even
Console.Write("Geef een getal : ");
int getal = int.Parse(Console.ReadLine());

string result;
bool isEven =  (getal % 2) == 0;
if (isEven == true)
{
	result = "Dit getal is even.";
}
else
{
	result = "dit getal is oneven";
}
Console.WriteLine(result);
```

#### oefening D02absolutewaarde
```C# title:D02absolutewaarde
Console.Write("Geef een getal : ");
int getal = int.Parse(Console.ReadLine());

int absoluteWaarde;
if (getal < 0)
{
	absoluteWaarde = -getal;
}
else
{
	absoluteWaarde = getal;
}
Console.WriteLine($"de absolute waarde is : {absoluteWaarde}");
```
