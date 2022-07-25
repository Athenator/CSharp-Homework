/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

double a = 0;

Console.Write($"Введите число: ");

string number1 = Console.ReadLine();
a = double.Parse(number1);

if (a % 2 == 0)
{
    Console.WriteLine($"Число {a}, является четным");
}
else
{
    Console.WriteLine($"Число {a}, является нечетным");
}
