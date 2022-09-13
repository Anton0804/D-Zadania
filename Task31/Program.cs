﻿// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

Console.Clear();
Console.WriteLine();
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.LongLength; i++)
    {
        if (i < array.LongLength - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] Gett


// int [] arr = CreateArrayRndInt(12,-9, 9);
// PrintArray(arr);

// void PrintArray (int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.Write("]");
// }                                    (Для печати массива)



// int[] GetSumPosNegElem(int[] array)
// {
//     int sumNeg = 0;
//     int sumPos = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0) sumNeg += array[i];
//         else sumPos += array[i];
//     }

//     return new int[]{sumNeg, sumPos};
// }



// int[] arr = CreateArrayRndInt(12, -9, 9);
// PrintArray(arr);
// Console.WriteLine();
// int[] result = GetSumPosNegElem(arr);
// Console.WriteLine($"Сумма отрицательных чисел = {result[0]}");
// Console.WriteLine($"Сумма положительных чисел = {result[1]}");
