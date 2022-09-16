// Найти произведение двух матриц

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FinalArray(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
                matr3[i, j] += matr1[i, k] * matr2[k, j];
        }
    }
    return matr3;
}

Console.WriteLine("Введите количество строк первой матрицы: ");
int i1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int j1 = int.Parse(Console.ReadLine());
int[,] matrix1 = new int[i1, j1];

Console.WriteLine("Введите количество строк второй матрицы: ");
int i2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int j2 = int.Parse(Console.ReadLine());
int[,] matrix2 = new int[i2, j2];

if (i1 != j2 || j1 != i2) Console.WriteLine("Невозможно найти произведение матриц. Количество столбцов и строк неодинаковое");
else
{
    FillArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine("Матрица 1:");
    PrintArray(matrix1);
    Console.WriteLine("Матрица 2:");
    PrintArray(matrix2);
    Console.WriteLine("Произведение матриц:");
    PrintArray((FinalArray(matrix1, matrix2)));
}