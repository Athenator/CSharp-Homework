/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.Write("Введите пятизначное число: ");

string number = Console.ReadLine();

if(number[0] == number[number.Length -1])
{
    if(number[1] == number[number.Length -2] )
    {
        Console.Write($"{number} -> да");
    }else{
        Console.Write($"{number} -> нет");
    }
   
}else
{
    Console.Write($"{number} -> нет");
}
