/* Console.Clear();

int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");    

Console.WriteLine(array[3]);       // сложность O(1)    одно действие
//Сложность алгоритма(онатация) - O(n) Сколько действий мы выполнили чтобы узнать конечный результат!!!

int summa = 0;                     // сложность O(n)    где n количество э-ов в массиве!!!
for (int i = 0; i < n; i++)
    summa += array[i];
Console.WriteLine(summa);     

// [4, 5, 3, 1, 2]
// O(n)
// [1, 2, 3, 4, 5] = O(n * log n) - быстрая сортировка
// ((5 + 1) / 2) * 5 = O(1)
// n < n * log(n) + 1 */


/* // Выводим таблицу умнажения с сложностью O(n^2)
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");
    }
    Console.WriteLine();
} */


/* // Выводим таблицу умнажения с сложностью O(n^2 / 2)
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}  

void WriteArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();    
        
    }
}

WriteArray(matrix); */
