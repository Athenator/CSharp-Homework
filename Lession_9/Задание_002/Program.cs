/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int N = 0;
int M = 0;

Console.Write("Начальное число: ");
int.TryParse(Console.ReadLine(), out M);
Console.Write("Конечное число: ");
int.TryParse(Console.ReadLine(), out N);

string PrintNum(int start, int end)
{
  int sum = start;
  if(start == end)
  {
    return sum.ToString();
  }
   while(start < end) 
    {
    sum += start + 1;
    start++;
    }
    return sum.ToString();
}
if(M > N)
{
  Console.Write("Числа введены некорректно!");
}
else
{
  Console.Write(" -> ");
  Console.Write(PrintNum(M,N));
}
