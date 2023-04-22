//Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArraySpiral(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    int n = 0;
    int x = 0;
    int y = 0;
    int z = 0;
    int finish = cntRows * cntColumns;
    int crutch = array.GetLength(1) - 2;

    while (n < finish)
    {
        x = 0 + z;
        y = 0 + z;
        for (int i = x; i < array.GetLength(1) - z && n != finish; i++)
        {
            array[y, i] = n;
            n++;
        }
        z++;
        x = array.GetLength(1) - z;
        for (int m = z; m < array.GetLength(0) - y && n != finish; m++)
        {
            array[m, x] = n;
            n++;
        }
        y = array.GetLength(0) - z;
        for (int k = crutch; k >= 0 + z - 1 && n != finish; k--)
        {
            array[y, k] = n;
            n++;
        }
        crutch--;
        x = 0 + z;
        for (int l = y - 1; l > 0 + z - 1 && n != finish; l--)
        {
            array[l, x - 1] = n;
            n++;
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

System.Console.WriteLine();
int cntColumns = ReadInt($"Колличество колонок первой матрицы");
int cntRows = ReadInt($"Колличество строк первой матрицы");

System.Console.WriteLine();
System.Console.WriteLine("Первая матрица:");
int[,] table = Generate2DArraySpiral(cntColumns, cntRows);
System.Console.WriteLine();
Print2DArray(table);
