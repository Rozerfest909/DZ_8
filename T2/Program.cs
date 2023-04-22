// // Задача 2: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[] Sum(int[,] array)
{
    int[] Sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Sum[i] = sum;
    }
    return Sum;
}

void PrintArray(int[] array)
{
    int min = array[0];
    int minI = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minI = i;
        }
    }
    System.Console.WriteLine($"Строка с наименьшой суммой элементов: {minI + 1}");
}

System.Console.WriteLine();
int cntColumns = ReadInt($"Колличество колонок");
int cntRows = ReadInt($"Колличество строк");
System.Console.WriteLine();
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
System.Console.WriteLine();
PrintArray(Sum(table));

