Console.Write("min = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("max = ");
int num2 = Convert.ToInt32(Console.ReadLine());
int count = Math.Abs(num1 - num2);
Change(count, num1, num2);


void Change(int diff, int min, int max)
{
    if (diff == 0) 
    {
        Console.WriteLine("New min = " + min);
        Console.WriteLine("New max = " + max);
        return;
    }
    Change(--diff, ++min, --max);
}