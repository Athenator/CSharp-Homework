/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


Console.Write("Введите колличество чисел в массиве: ");

int [] array = new int[int.Parse(Console.ReadLine()!)];

Console.Write("[");

int count = 0;

for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($" {array[i]}, ");
    if(array[i] % 2 == 0)
    {
        count ++;
    }
}
Console.Write($"] -> {count}");