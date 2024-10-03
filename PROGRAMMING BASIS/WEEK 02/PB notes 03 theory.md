### 1 strings bouwen met string interpolatie
**string** **interpolatie**
=> `$` voor de **string literal** zetten
=> in de string tussen `{...}` een `<var>` plaatsen
vb.:
```c#
string naam = "jan";
int leeftijd = 34;

string bericht = $"{naam} is {leeftijd} jaar oud.";
Console.Write(bericht);
```
als je in deze string literal met interpolatie een `}` wil hebben, moet je deze verdubbelen `}}`

### 2 werken met getallen
#### 2.1 rondom getallen
om random getallen te bekomen moet je eerst deze initialiseren met deze lijn:
```C#
Random <rnd> = new Random();
```

om random getal te krijgen = `<rnd>.Next()`:
```c#
Random <rnd> = new Random();
int <randomInt> = <rnd>.Next();
```

bv.:
```C#
Random rnd = new Random(); 
int worp1 = rnd.Next(1, 7); 
int worp2 = rnd.Next(1, 7);

Console.WriteLine(worp1);
Console.WriteLine(worp2);
```

#### 2.2 Math functionaliteit

**Math klasse**
=>bevat veel **functies** die wiskundige berekeningen makkelijker maken.
official documentation:
- [https://docs.microsoft.com/en-us/dotnet/api/system.math](https://docs.microsoft.com/en-us/dotnet/api/system.math)

| functie                          | uitleg                                                |
| -------------------------------- | ----------------------------------------------------- |
| ``Math.Min(<var1>, <var2>)`      | neemt de kleinste waarde tussen `<var1>` en `<var2>`  |
| ``Math.Max(<var1>, <var2>)`      | neemt de grootste waarde tussen `<var1>` en `<var2>`  |
| `Math.PI`                        | de waarde van Pi = 3.14159...                         |
| `Math.Pow(<double1>, <double2>)` | resultaat is `<double1>` tot de macht van `<double2>` |
| `Math.Sqrt(<double>)`            | berekent de vierkantswortel van `<double>`            |
| `Math.Abs(<double>)`             | geeft de absolute waarde van `<double>`               |
#### 2.3 verkorte notatie voor eenvoudige berekening

| voluit                     | verkort            |
| -------------------------- | ------------------ |
| `<var> = <var> + 1`        | `<var>++`          |
| `<var> = <var> - 1`        | `<var>--`          |
| `<var1> = <var1> + <var2>` | `<var1> += <var2>` |
| `<var1> = <var1> - <var2>` | `<var1> -= <var2>` |
| `<var1> = <var1> * <var2>` | `<var1> *= <var2>` |
| `<var1> = <var1> / <var2>` | `<var1> /= <var2>` |
### 3 Variabelen en scope
**Declaratie van een variabele**:
- introduceert variabele
- geeft deze een naam
- geeft ze een datatype
=> compiler maakt code tijdens uitvoering die een opslagplaats voorziet in het geheugen
vb.:
```c# 
int i = 12; 
double d = 34.56; 
string s = "Hello world!";
```

#### 3.1 Naamgeving en declaraties
Regels rond **naamgeving** van **variabelen**
- variabelen **starten** met een **Lower Case** 
- **camelCasing**: als naam uit meerdere woorden bestaat => alles behalve 1ste woord begint met een Upper Case
- **nooit** een **prefix** die het **datatype** aanduid van de variabele
- introduceer enkel **1 variabele per lijn**
- **CONSEQUENTIE!!!!**

#### 3.2 Scope
**scope** of a `<var>`  defines where the `<var>` can be accessed/modified.
**Scope** holds the current state of variables along with their respective values
Scope of a `<var>` starts with the declaration and ends with the end of the codeblock/scope

categories of scope
- Block level scope
	- generally in codeblock of if/else, for, while statements
	- limited to the codeblocks they are declared in
	- These variables are also termed as the loop variables or statements variable as they have limited their scope up to the body of the statement in which it declared.
- method level scope
	method = the block of codes or statements in a program that gives the user the ability to **reuse** the same code
	
- class level scope


**==much better explanation:==**
https://www.geeksforgeeks.org/scope-of-a-variable/

### 4 Traceertabellen
