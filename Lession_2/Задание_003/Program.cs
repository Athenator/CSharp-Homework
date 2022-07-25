/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int day = 0;
int workday = 5;

Console.Write("Введите число, соответсвующее дню недели: " );

string number = Console.ReadLine();
day = int.Parse(number);

if(day <= workday)
{
    Console.Write("-> Нет");
}
else
{
    Console.Write("-> Да ");
}
