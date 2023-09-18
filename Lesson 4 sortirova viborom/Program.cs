Console.Clear();

int[] array = {2, 7, -3, 8, 2, 1};

void SortSelection(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
            if(array[j] < array[min]) min = j;
        
        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
}

Console.WriteLine($"[{String.Join(',', array)}]");
SortSelection(array);
Console.WriteLine($"[{String.Join(',', array)}]");














