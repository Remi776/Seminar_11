Console.Write("Enter the m: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the n (n < m): ");
int b = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
FillArray(array, b, a);
PrintArray(array);

void FillArray(int[] arr, int n, int m)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(n, m + 1);
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i], -5}");
    }
}