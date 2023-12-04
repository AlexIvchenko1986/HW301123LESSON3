Console.Clear();

// ## Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива. 

// **Пример :**
// * _массив [2.2 0.4 9.11 7.2 78.98] => 78.58_
// * _массив [1.22 4.5 3.33] => 3.28_

double[] array = new double[6];
double min = Int32.MaxValue;
double max = Int32.MinValue;


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 99) + new Random().NextDouble();
    Console.Write($"{array[i]}; ");
    Console.WriteLine();

    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

