/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Write("Введите колличество чисел в массиве: ");

int [] array = new int[int.Parse(Console.ReadLine()!)];

int r = 0;

Console.Write("[");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100);
    Console.Write($" {array[i]} ");
    

}

int max = array[0];
int min = array[0];

for(int i = 1; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array [i];
    }
    if(min > array[i])
    {
        min = array[i];
    }

}   
Console.Write("]");

r = max - min;
Console.Write($"-> {r} ");
Console.WriteLine();
Console.Write($"Max = {max}\nMin = {min}");
