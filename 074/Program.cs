int[] arrayA = { 1, 3, 5, 7 };
int[] arrayB = { 4, 5, 6, 7 };
int[] NewArray = new int[arrayA.Length + arrayB.Length];
Xor(arrayA, arrayB);

void Xor(int[] arr1, int[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = 0; j < arr2.Length; j++)
        {
            if (arr1[i] == arr2[j]) break;
        }
        NewArray[i] = arr1[i];
    }
    PrintArray(NewArray);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}




