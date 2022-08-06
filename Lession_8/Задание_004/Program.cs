/*Сформируйте трёхмерный массив. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int m = 2;
int n = 2;
int e = 2;

int [,,] array = new int[m,n,e];

void FillArr(int[,,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          for (int k = 0; k < e; k++)
          {
            array[i,j,k] = new Random().Next(10,100);
          } 

        }

    }
}

void PrintArr(int[,,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < e; k++)
            {
              
              
              Console.Write($" {array[i,j,k]}({i},{j},{k})");
              
            }
          Console.WriteLine();
        }
      
    }
        
}


FillArr(array);
PrintArr(array);
