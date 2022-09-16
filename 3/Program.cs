// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран 
// выводя индексы соответствующего элемента

void FillArray(int[,,] matr)
{
    int count = 10;
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = new Random().Next(0, 10);
            }
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
                Console.Write($"Элемент[{i},{j},{k}] = {matr[i, j, k]} ");
            Console.WriteLine();
        }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите глубину матрицы: ");
int c = int.Parse(Console.ReadLine());
int[,,] matrix = new int[a, b, c];
FillArray(matrix);
PrintArray(matrix);