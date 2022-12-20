using static System.Console;
WriteLine("Enter a three-digit number: ");
int a = int.Parse(ReadLine()!);
WriteLine(((a % 100) - (a % 10)) / 10);