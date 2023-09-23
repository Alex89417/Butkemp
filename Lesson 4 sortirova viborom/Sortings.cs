public static class Sortings
{
    public static int[] SortSelection(this int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
                if(array[j] < array[min]) min = j;
            if (array[min] == array[j])
                continue;
                
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
        return array;
    }
}
