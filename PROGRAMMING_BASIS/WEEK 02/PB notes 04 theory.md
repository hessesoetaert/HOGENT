## 1. Invoer meteen converteren
To instantly convert the input of `{c#} Console.ReadLine()` or `{c#} Console.Read()` 
=> put in into a `{c#} .Parse()` method.
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
//correct if ... else if ... else block
if (condition1) {
	<code_block_1>
} 
else if (condition2){
	<code_block_2>
}
else if (condition3){
	<code_block_3>
}
else {
	<code_block_4>
}

//NOT THE SAME AS
if (condition1) {
	code block 1
}
if (condition2) {
	code block 2
}
if (condition3) {
	code block 3
}
```
Deze controle structuren zijn linked. => like one block
the program wil check conditions until there is a condition that results `{c#} true`

If the first condition is false the statement will automatically check the next condition until there is an `{c#} else` statement or the chain ends.

This new condition has to be in an `{c#} else if` statement or an `{c#} else` statement. 
`{C#} else if` statement will check the new condition without any regard for the last system
the `{C#} else` statement will only execute if none of the other conditions were met and end the link

`{c#} if` statements in succession just makes them execute individually, in order, unconditionally

BETTER EXPLENATION:
https://www.geeksforgeeks.org/c-sharp-if-else-statement/?ref=header_outind
## 4. Logische bewerkingen

| &&   | AND |
| ---- | --- |
| \|\| | OR  |
| !    | NOT |

## 5. Interval checking
read cursus pls
## 6. Invoer robuust opvangen

```csharp
string woord = " UPpOrDoWn "

woord.ToUpper() //=> converts all char to UpperCase 
woord.toLower() //=>converts all char to LowerCase

woord.Trim() //=> trims spaces in front and on the end of the string
```