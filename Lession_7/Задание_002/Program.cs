/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/
Console.Write("Введите колличество стобцов в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество чисел в столбце массива: ");
int n = int.Parse(Console.ReadLine()!);

int [,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(100);

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
Console.Write("Введите число, которое хотите найти в массиве: ");
int sn = int.Parse(Console.ReadLine()!);
int SearchNum(int searchNum, int [,] searchArr)
{
bool a = false;
    
    for (int i = 0; i < searchArr.GetLength(0); i++)
    {
        for (int j = 0; j < searchArr.GetLength(1); j++)
        {
            if(searchNum == searchArr[i,j])
            {
                a = true;
                Console.WriteLine($"{searchNum} -> в строчке {i+1} и является {j+1} в ней по счету! ");
            }
        }
        
    }

if(a == false)
{
    Console.WriteLine($"{searchNum} -> такого числа в массиве нет!");
}
return searchNum;

}

SearchNum(sn,array);

