﻿//                                     Рекурсия -> Быстрая сортировка O(n * log2(n))

/* // Напишите программу которая сложит 2 числа a и b, без прямого сложения

int sumNumbers(int x, int y)
{
    if(x == 0) return y;
    return sumNumbers(x - 1, y + 1);
}

Console.Clear();
Console.Write("Введите 2 числа: ");
int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"Результат {numbers[0]} + {numbers[1]} = {sumNumbers(numbers[0], numbers[1])}");

// sumNumbers = S
// S(3, 4) -> S(2, 5)
//            |
//            S(1, 6)
//            |
//            S(0, 7)
//            |
//            7
// S(3, 4) = S(2, 5) = S(1, 6) = S(0, 7) = 7 */



/* // Как работает быстрая сортировка:

// Берем опорный элемент - обычно первый элемент в массиве!! 
// [7, 4, 1, 3, 5, 2, 6] -> [1, 2, 3, 4, 5, 6, 7]

// pivot = 7              - опорный элемент
// [4, 1, 3, 5, 2, 6] + [7] + []
// pivot = 4              - опорный элемент
// [1, 3, 2] + [4] + [5, 6]
// pivot = 1              - опорный элемент
// [] + [1] + [3, 2]
// pivot = 5              - опорный элемент
// [] + [5] + [6]
// pivot = 3              - опорный элемент
// [2] + [3] + []

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 20);
}

int[] quickSort(int[] array, int leftIndex, int rightIndex)  
{
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];    
    while (i <= j)
    { 
        while (array[i] < pivot) i++; 
        while (array[j] > pivot) j--;    
        if (i <= j)                      
        {
            int temp = array[i];    
            array[i] = array[j]; 
            array[j] = temp;         
            i++;    
            j--;    
        }
    }
    if (leftIndex < j) quickSort(array, leftIndex, j);
    if (i < rightIndex) quickSort(array, i, rightIndex);
    return array;
}

Console.Clear();
Console.Write("Введите длинну массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", quickSort(array, 0, n-1))}]"); */
