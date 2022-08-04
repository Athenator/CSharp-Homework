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
