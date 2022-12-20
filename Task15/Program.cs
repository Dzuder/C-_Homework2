using static System.Console;

WriteLine("Enter number of the day of the week: ");
int a = Convert.ToInt32(ReadLine()!);
string b = "Day";
// все что ниже с днями и переменная b, я сам решил усложнить для красивого ответа.
if (a == 1) {
   b = "Monday";
}
if (a == 2)
{
    b = "Tuesday";
}
if (a == 3)
{
    b = "Wednesday";
}
if (a == 4)
{
    b = "Tursday";
}
if (a == 5)
{
    b = "Friday";
}
if (a == 6)
{
    b = "Saturday";
}
if (a == 7)
{
    b = "Sunday";
}
WriteLine((a >= 6) && a <=7 ? "Yes, " + b + " is a weekend." : (a >=1 && a <= 5)? "No, " + b + " is not a weekend." : "In a week of 7 days, enter from 1 to 7." );

