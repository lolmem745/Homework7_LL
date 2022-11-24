void fillArray(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * 100;
            string result = arr[i, j].ToString("#.##");
            arr[i, j] = Convert.ToDouble(result);
        }

    }
}
void printArray(double[,] arr)
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
int m = 3, n = 5;
double[,] arr = new double[m, n];
fillArray(arr);
printArray(arr);
