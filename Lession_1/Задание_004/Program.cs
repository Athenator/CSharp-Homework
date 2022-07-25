/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

int n = 0;
int i = 1;

Console.Write("Введите число: ");

string number1 = Console.ReadLine();
n = int.Parse(number1);

while(n >= i)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }

    i ++;
   
}
