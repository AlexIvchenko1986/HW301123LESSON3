﻿// ## Задача 1: Задайте одномерный массив из 10 целых чисел 
//от 1 до 100. Найдите количество элементов массива, значения 
//которых лежат в отрезке [20,90]. 

// **Пример :**
// * _массив [10 21 14 93 23] => 2_


int[] array = { 12, 8, 9, 25, 33, 97, 19, 39, 89, 77 };
int count = 0;
int n = array.Length;
int min = 20;
int max = 90;

for (int i = 0; i < n; i++)
{
    if ((array[i] >= min) && (array[i] <= max))
    {
        count++;
    }
}
Console.Write($" Количество элементов в диапозоне {count}");