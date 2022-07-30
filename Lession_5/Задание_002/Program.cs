/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

Console.Write("Введите колличество чисел в массиве: ");

int [] array = new int[int.Parse(Console.ReadLine()!)];

Console.Write("[");


int sum = 0;

for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(-10, 100);
    Console.Write($" {array[i]}, ");
    if( i % 2 != 0)
    {
        sum += array[i];
        
    }
}
Console.Write($"] -> {sum}");