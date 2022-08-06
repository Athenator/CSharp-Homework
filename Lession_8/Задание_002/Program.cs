/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
int m = 4;
int n = 4;

int [,] array = new int[m,n];

void FillArr(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(10);

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

int sum1 = 0;
int sum2 = 0;
int stroke = 0;
for (int i = 0; i < m-1; i++)
{
    sum1 = 0;
    sum2 = 0;
    for (int j = 0; j < n; j++)
    {
        sum1 += array[i,j];
        
    }
    for (int k = 0; k < n; k++)
        {
            sum2 += array[i+1,k];
        }
    
    if(sum1 > sum2)
    {
        stroke = i;
    }
    else
    {
        stroke = i + 1;
    }
}

Console.Write($"Строка с наименьшей суммой элементов: {stroke}");
