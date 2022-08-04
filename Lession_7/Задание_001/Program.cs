    /*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    m = 3, n = 4.

    0,5 7 -2 -0,2

    1 -3,3 8 -9,9

    8 7,8 -7,1 9*/

Console.Write("Введите колличество строк в массиве(m): ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину массива в строке (n): ");
int n = int.Parse(Console.ReadLine()!);

double [,] array = new double [m,n];

for (int i = 0; i < m; i++)
{
    
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(-100,100);
        array[i,j] /= 10;
    }
    
}

void PrintAray (double [,] array)
{

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          Console.Write($"[");
          Console.Write($"{array[i,j]}");
          Console.Write($"]");
        }
        Console.WriteLine();
    }

}

PrintAray(array);
