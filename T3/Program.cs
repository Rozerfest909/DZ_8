// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

int[,] MultiMatrix(int[,] array, int[,] array2)
{
    int[,] Group = new int[array.GetLength(0), array2.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                temp = array[i, k] * array2[k, j];
                Group[i, j] += temp;
            }
        }
    }
    return Group;
}

bool Validate(int C1, int R1, int C2, int R2)
{
    if (R1 == C1 || C1 == R2)
    {
        return true;
    }
    Console.WriteLine("Матрицы таких размеров не возможно умножить");
    return false;
}

System.Console.WriteLine();
int cntColumns = ReadInt($"Колличество колонок первой матрицы");
int cntRows = ReadInt($"Колличество строк первой матрицы");
System.Console.WriteLine();
int cntColumns2 = ReadInt($"Колличество колонок второй матрицы");
int cntRows2 = ReadInt($"Колличество строк второй матрицы");

System.Console.WriteLine();
System.Console.WriteLine("Первая матрица:");
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);

System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица:");
int[,] table2 = Generate2DArray(cntColumns2, cntRows2);
Print2DArray(table2);

System.Console.WriteLine();
System.Console.WriteLine("Произведение двух матриц:");
if (Validate(cntColumns, cntRows, cntColumns2, cntRows2))
{
    Print2DArray(MultiMatrix(table, table2));
}


