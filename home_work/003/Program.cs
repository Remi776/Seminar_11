Console.Write("Enter a year: ");
int n = Convert.ToInt32(Console.ReadLine());
if (CheckLeapYear(n)) Console.WriteLine($"{n} is a leap year");
else Console.WriteLine($"{n} is not a leap year");

bool CheckLeapYear(int year)
{
    return ((year % 4 ==0 && year % 100 != 0) || year % 400 == 0);
}
