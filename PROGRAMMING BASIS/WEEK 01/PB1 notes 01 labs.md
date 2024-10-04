
do not put solutions in same directory -why?

enable do not use toplevel statements
toont -> 

```C#:
using System; 
namespace Project1 
{ 
	class Program 
	{ 
		static void Main() 
		{
		... 
		} 
	}
}
```

---
## **BASIS OEF**


##### Oefening D01codepositioneren
```C#
Random r = new Random();
int getal = r.Next(1, 101);
int gok = 0;
Console.WriteLine("De computer denkt aan een getal van 1 tem 100, kun je raden welk?");
do
{
    Console.Write("Wat gok je?: ");
    string input = Console.ReadLine();
    gok = int.Parse(input);
    if (gok < getal)
    {
        Console.WriteLine("Hoger!");
    }
    else if (gok > getal)
    {
        Console.WriteLine("Lager!");
    }
    else
    {
        Console.WriteLine("Disco!");
    }
} while (gok != getal);
```

---

##### Oefening D01centimetersnaarmeters
```C#: 
int lengteInCm = 713;
Console.WriteLine(lengteInCm);
Console.WriteLine("cm = ");

int volledigAantalMeters = lengteInCm / 100;
int aantalResterendeCm = lengteInCm - (volledigAantalMeters * 100);

Console.WriteLine(volledigAantalMeters);
Console.WriteLine("m en ");
Console.WriteLine(aantalResterendeCm);
Console.WriteLine("cm");
```

---

##### Oefening D01totalebedrag
```C#:
int biljettenVan10Euro = 7;
int biljettenVan5Euro = 6;
int muntstukkenVan2Euro = 5;
int muntstukkenVan1Euro = 4;
int muntstukkenVan50Cent = 3;

double totaalBedrag = (biljettenVan10Euro * 10) 
	+ (biljettenVan5Euro * 5) 
	+ (muntstukkenVan2Euro * 2) 
	+ muntstukkenVan1Euro
	+ (muntstukkenVan50Cent / 2.0);

Console.WriteLine(totaalBedrag);
```

---

##### Oefening D01bmi
```C#:
int lengteInCm = 182;
int gewichtInKg = 72;

double lengteInM = lengteInCm / 100.0;
double bmi = gewichtInKg / Math.Pow(lengteInM,2); 

Console.WriteLine(bmi);
```

---

##### Oefening D01Waardesomwisselen
```C#:
int a = 5;
int b = 13;
int switchNumber = 0;

switchNumber = a;
a = b;
b = switchNumber;


Console.WriteLine(a);
Console.WriteLine(b);
}
```

---

##### Oefening D01euronaarpound
```C#:
double euroBedrag = 105.4;
double wisselkoersEurToPound = 0.88;
double poundBedrag = euroBedrag * wisselkoersEurToPound;

Console.Write(euroBedrag);
Console.Write("EUR = ");
Console.Write(poundBedrag);
Console.Write("GPB");
```

---


