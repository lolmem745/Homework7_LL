void fillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }

    }
}
void printArray(int[,] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
            if (j != arr.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i == arr.GetLength(0) - 1) Console.Write("]");
        Console.Write($"\n");

    }

}
void midArithm(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            result = result + arr[j, i];
        }
        result = result / arr.GetLength(0);
        Console.Write($"{result} ");
    }
}
int[,] arr = new int[5, 4];
fillArray(arr);
printArray(arr);
midArithm(arr);