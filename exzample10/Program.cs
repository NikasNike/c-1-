int[] array = {100, 52, 83, 46, 15, 76, 76, 278, 99 };

int n = array.Length;
int find = 76;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
   
    index++;
}