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

int max = array[0,0];
int maxI = 0;
int temp = 0;
int min = 1;
for (int i = 0; i < m; i++)
{
    
    for (int end = n; end > 1; end--)
    {
        max = array[i,0];
        temp = 0;
        maxI = 0;
        
        for (int j = 1; j < end; j++)
            {
                if(max < array[i,j])
                {
                    max = array[i,j];
                    maxI = j;
                
                }
                
            }

        if(max > array[i,end-1])
        {
        temp = array[i,maxI];
        array[i,maxI] = array[i,end-1];
        array[i,end-1] = temp;
        
        }
        
    }
   
    
}
Console.WriteLine($"Новый массив: ");

PrintArr(array);