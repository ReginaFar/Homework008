//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int [,] numbers = new int [rows,columns];
    FillArray(numbers);
    PrintArray(numbers);
    int min = numbers[0,0];
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            if (numbers[i,j] > min)
            {
                int tmp = numbers[i,j];
                numbers[i,j] = numbers[i, j + 1];
                numbers[i, j + 1] = tmp;
            }
        }
        Console.WriteLine();
    }
    PrintArray(numbers);
}
void FillArray(int [,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0,10);
        }
    }
}
void PrintArray(int [,] numbers)
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
Zadacha54();
