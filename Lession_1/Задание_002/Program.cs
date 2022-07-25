/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a = 0;
int b = 0;
int c = 0;

Console.Write("Введите первое число: ");

string number1 = Console.ReadLine();
a = int.Parse(number1);

Console.Write("Введите второе число: ");

string number2 = Console.ReadLine();
b = int.Parse(number2);

Console.Write("Введите третье число: ");

string number3 = Console.ReadLine();
c = int.Parse(number3);

if (a > b) {

    int max = a;
    if (max > c)
    {
        Console.Write($"max = {max}");
    }

    else
    {
        max = c;
        Console.Write($"max = {max}");
    }

}
else
{
    int max = b;
    if (max > c)
    {
        Console.Write($"max = {max}");
    }
    else
    {
        max = c;
        Console.Write($"max = {max}");
    }

}


