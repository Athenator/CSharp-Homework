/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int a1 = 7;
int b1 = -5;
int c1 = 0;

int a2 = 1;
int b2 = -1;
int c2 = 9;

void Example(int num1, int num2, int num3, int numb1, int numb2, int numb3)
{
    int ex1 = (numb1 - num1) * (numb1 - num1); 
    int ex2 = (numb2 - num2) * (numb2 - num2);
    int ex3 = (numb3 - num3) * (numb3 - num3);
    int sum = ex1 + ex2 + ex3;
    Console.Write($"A ({num1}, {num2}, {num3}); B ({numb1}, {numb2}, {numb3}); -> {MathF.Sqrt(sum)}");
}

Example(a1,b1,c1,a2,b2,c2);