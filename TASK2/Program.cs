// ## Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
//которая определяет количество чётных чисел в массиве.

// **Пример :**
// * _массив [6 7 19 34 3 1 4 7 9 1] => 3_
// * _массив [1 8 43 4 55 60 3 2 1 3] => 4_

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
        Console.Write($" Количество четных чисел {count} ");
    }
    else
    {
        Console.Write("Четные числа не найдены ");
    }

}