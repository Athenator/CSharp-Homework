/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

n = 2, m = 3 -> A(n,m) = 29
*/
int n = 0;
int m = 0;
Console.Write("Введите число n: ");
int.TryParse(Console.ReadLine(), out n);
Console.Write("Введите число m: ");
int.TryParse(Console.ReadLine(), out m);
            
int A(int n, int m)
{
  if (n == 0)
  {
  return m+1;
  }
  if (n != 0 && m == 0) 
  {
  return A(n - 1, 1);
  }
  if (n > 0 && m > 0)
  {
  return A(n - 1, A(n, m - 1));
  }
  
  return A(n,m);
}
Console.Write($"-> Aккерман ({n},{m}) = ");
Console.Write(A(n,m));