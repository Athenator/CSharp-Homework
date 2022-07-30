/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int Degree(int num1, int num2)
{
    int sum = 1;
    
    for(int i = 0; i < num2 ; i++)
    {
        sum = sum * num1;
        
        Console.WriteLine(sum);
    }

    return sum;
}

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write($"{a}, {b} -> {Degree(a, b)}");