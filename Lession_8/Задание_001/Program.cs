/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Введите колличество стобцов в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество чисел в столбце массива: ");
int n = int.Parse(Console.ReadLine()!);

int [,] array = new int[m,n];

void FillArr(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(50);

        }

    }
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("[");
            Console.Write($"{array[i,j]}");
            Console.Write("]");
        }
        Console.WriteLine();
    }
}

FillArr(array);
PrintArr(array);


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n - 1; k++)
        {
            if(array[i,k] < array[i, k + 1])
            {
                int buff = array[i, k + 1];
                array[i,k+1] = array[i,k];
                array[i,k] = buff;
            }
        }
    }
}


Console.WriteLine($"Новый массив: ");

PrintArr(array);