// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
Console.WriteLine("Введите число,которое нужно найти в массиве");
int num = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array);
FindNumber(array, num);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void FindNumber(int[,] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)

            if (array[i, j] == num)
            {
                System.Console.WriteLine($"{num} под индексами [{i},{j}]");
                count++;

            }
    if (count == 0) System.Console.WriteLine("Такого элемента нет");
}







