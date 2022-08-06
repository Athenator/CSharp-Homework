/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int n = 4;

int [,] array = new int[n,n];

void SpiralArray(int [,] array)
{
    int first = 0;
    int second = 0;
    int x = 1;
    int y = 0;
    int changes = 0;
    int visits = n;

    for (int i = 0; i < n * n; i++) 
    {
        array[first, second] = i + 1;
            if (--visits == 0) 
            {
                visits = n * (changes % 2) + n * ((changes + 1) % 2) -(changes / 2 - 1) - 2;
                int temp = x;
                x = -y;
                y = temp;
                changes++;
            }
            second += x;
            first += y;
        }
        
       
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i,j] / 10 == 0)
            {
            Console.Write($"0{array[i,j]} ");
            }
            else 
            {
            Console.Write($"{array[i,j]} ");
            }
            
        }
        Console.WriteLine();
    }
}


SpiralArray(array);
PrintArr(array);

