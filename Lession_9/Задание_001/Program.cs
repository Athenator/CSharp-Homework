/*Задайте значения S и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

int N = 0;
int M = 0;
Console.Write("Начальное число: ");
int.TryParse(Console.ReadLine(), out M);
Console.Write("Конечное число: ");
int.TryParse(Console.ReadLine(), out N);


string PrintNum(int start, int end)
{
  if(start == end)
    return start.ToString();
  return(start + " " + PrintNum(start + 1, end));
}
if(M > N)
{
  Console.Write("Числа введены некорректно!");
}
else
{
  Console.Write(PrintNum(M,N));
}
