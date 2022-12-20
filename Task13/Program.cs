using static System.Console;
WriteLine("Enter a number: ");
int a = int.Parse(ReadLine()!);
//WriteLine(a > 99? (a - ((a % 100) + (a % 10)) / 10) : "There are no third digits in the entered number") ;
//WriteLine((a - (a % 100)) / 100);
WriteLine(a > 99? (a % 1000 / 100) : "There are no third digits in the entered number");