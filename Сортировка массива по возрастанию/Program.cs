int [] array = {6,43,20,-8};

int n = array.Length;

for (int end = n; end > 1; end--)
{
    int max = array[0];
    int maxI = 0;
    for (int i = 1; i < end; i++)
    {
        if(max < array[i])
        {
            max = array[i];
            maxI = i;
        }
    }
    if(max > array[end-1])
    {
        int tmp = array[maxI];
        array[maxI] = array[end-1];
        array[end-1] = tmp;
    }

}
Console.Write("[");
Console.Write(array[0]);Console.Write(", ");Console.Write(array[1]);Console.Write(", ");
Console.Write(array[2]);Console.Write(", "); Console.Write(array[3]);Console.Write(", ");
Console.Write("]");
