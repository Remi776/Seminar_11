void FillArray(int[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = rnd.Next(1, 11);
        }
    }
}

void PrintArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write($"{coll[i, j], -5}");
        }
        Console.WriteLine();
    }
}

void SumNumberGreater5(int[,] mat)
{
    Console.WriteLine();
    int summ = 0;
    int count = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] > 5)
            {
                Console.Write($"{mat[i, j],-3}");
                count += 1;
                summ += mat[i, j];
            }
        }
    }
    Console.WriteLine($"\n\nNumber of elements greater then 5 = {count}");
    Console.WriteLine($"Sum of numbers greater then 5 = {summ}");
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
SumNumberGreater5(matrix);
