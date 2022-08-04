/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Write("Введите колличество стобцов в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество чисел в столбце массива: ");
int n = int.Parse(Console.ReadLine()!);

int [,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(10);

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

PrintArr(array);

double average = 0;
int count = 0;

Console.Write($"Среднее арифметическое для каждого столбца: ");
for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m ; j++)
    {
        average += array[j,i];
        count ++;
       
        
    }
    Console.Write($"{average/m}; ");
 average = 0;
 
}
