/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

Console.Write("Введите М колличества чисел: ");
int м = int.Parse(Console.ReadLine()!);
int [] array = new int[м];
int r = 0;

for(int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine()!);
    array[i] = n;
    Console.WriteLine($"Число {i + 1} = {array[i]} ");
    if(n > 0)
    {
        r += 1;
    }
}
Console.Write($"Колличество чисел больше 0 -> {r}");
