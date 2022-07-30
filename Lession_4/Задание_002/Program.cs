/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/



Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int b = n;

int sum = 0;

while(n > 0)
{
    sum += n % 10;
    n = n / 10;

}

Console.Write($"Сумма цифр в числе {b} -> {sum}");
