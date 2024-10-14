## 1. Invoer meteen converteren
To instantly convert the input of `Console.ReadLine()` or `Console.Read()` 
=> put in into a `Parse()` method.
ex.:
```csharp
Console.Write("Geef het aantal deelnemers : "); 
int aantalDeelnemers = int.Parse(Console.ReadLine()); 

int helft = aantalDeelnemers / 2; 
Console.WriteLine($"De helft van dat aantal is: {helft}")
```

## 2. Debugging
**compile errors:**
=> compiler does not understand/ wants to hinder you from executing 
**Runtime errors (Exceptions):**
=> errors that happen while executing  = exceptional errors
**Logic errors:** 
=> no compiler or runtime error but does not do what's expected
ex. wrong calculations
#### 2.1 Debugging in VS
in Locals window you can find the variables on the stack to help debug (_**Debug > Windows >Locals**_)

extra information about the stack: 
https://www.geeksforgeeks.org/c-sharp-stack-with-examples/

**Breakpoint**: code halts when trying to execute a line of code where the breakpoint is located.
=> in locals we can now see the variables and their values
=> you can execute the code **step-by-step** and track the changes to values of vars

## 3. If ... else if ... else ...
```csharp
if (condition1) {
	<code_block_1>
} 
else if (condition2){
	<code_block_2>
}
else {
	<code_block_3>
}
```
`else`
## 4. Logische bewerkingen
## 5. Interval checking
## 6. Invoer robuust opvangen

```csharp

```