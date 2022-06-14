// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine($"Таблица чисел от 1 до {number} в кубе");

for (int count = 1; count <= number; count++)
{
   if (count != number) Write($"{Math.Pow(count, 3)}, ");
   else Write($"{Math.Pow(count, 3)}\n");
}