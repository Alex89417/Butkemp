/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
Console.WriteLine("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 21);
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1 - i; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + 1 + " [" + string.Join(", ", array) + "]");
}
