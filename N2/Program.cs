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
    Console.Write("\n[");
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
    Console.Write($"\n");
}
void prinArrElem(double[,] arr, int i, int j)
{
    if (i > arr.GetLength(0) - 1) Console.Write("Такого числа нет");
    else if (j > arr.GetLength(1) - 1) Console.Write("Такого числа нет");
    else Console.Write($"Элемент массива с индексами ({i},{j}) равен {arr[i, j]}");
}

int m = 5, n = 5;
double[,] arr = new double[m, n];
fillArray(arr);
printArray(arr);
Console.Write("Введите первый индекс: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй индекс: ");
int j = Convert.ToInt32(Console.ReadLine());
prinArrElem(arr, i, j);
