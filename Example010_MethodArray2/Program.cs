int[] array ={11, 21, 31, 42, 12, 55, 34, 22, 555, 12};

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index ++;
}