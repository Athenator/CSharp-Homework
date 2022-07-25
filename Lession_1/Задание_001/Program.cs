// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3 

int a = 0;
int b = 0;

Console.Write("Введите первое число: ");

string username1 = Console.ReadLine();
a = int.Parse(username1);

Console.Write("Введите второе число: ");

string username2 = Console.ReadLine();

b = int.Parse(username2);

if (a > b)
{
    int max = a;
    Console.Write("max = ");
    Console.Write(max);
}
else 
{
    int min = a;
    Console.Write("min = ");
    Console.Write(min);
}

if (a < b)
{
    int max = b;
    Console.Write(" max = ");
    Console.Write(max);
}
else 
{
    int min = b;
    Console.Write("min = ");
    Console.Write(min);
}


