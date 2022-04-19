void Fibonachi(int last, int next, int number)
{
    if ((number >= last) && (number <= next)) 
    {
        Console.WriteLine($"{number} -> {last} {next}");
        return;
    }
    int temp = last;
    last = next;
    next = temp; 
    Fibonachi(last, last + next, number);
}

Fibonachi(1,1, 17);
