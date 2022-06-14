// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;
using static System.Console;

Clear();

bool DefPolendrome(string palindrome, int first, int Last)
{
   bool isPolendrome = true;

   while (first < Last)
   {
      if (palindrome[first] == palindrome[Last])
      {
         first++;
         Last--;
      }
      else
      {
         isPolendrome = false;
         break;
      }
   }
   return isPolendrome;
}

int numberSigns = 5;
int first = 0;
int Last = numberSigns - 1;

Write($"Введите число {numberSigns} значное: ");
string? palindrome = ReadLine();

if (palindrome?.Length != numberSigns) WriteLine($"Вы ввели не {numberSigns} значное число!");
else
{
   if (DefPolendrome(palindrome, first, Last)) WriteLine("Палиндром");
   else WriteLine("НЕ палиндром");
}