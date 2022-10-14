//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Массив, отсортированный по убыванию:");
    SortToLower(numbers);
    PrintArray(numbers);
    Console.WriteLine();
}
void SortToLower(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = temp;
                }
            }
        }
    }
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(6, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    LeastSumRow(numbers);
}
void LeastSumRow(int[,] numbers)
{
    int index = 0;
    int minSumRow = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sumRow = sumRow + numbers[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sumRow}");
        if (i == 0)
        {
            minSumRow = sumRow;
        }
        else if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            index = i;
        }
    }
    Console.WriteLine($"Номер строки с минимальной суммой элементов = {index + 1} ");
}
Zadacha54();
Zadacha56();

