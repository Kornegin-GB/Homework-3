// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
using static System.Console;

Clear();

WriteLine("Введите координаты точки А:");
Write("X = ");
int Ax = Convert.ToInt32(ReadLine());
Write("Y = ");
int Ay = Convert.ToInt32(ReadLine());
Write("Z = ");
int Az = Convert.ToInt32(ReadLine());


WriteLine("Введите координаты точки B:");
Write("X = ");
int Bx = Convert.ToInt32(ReadLine());
Write("Y = ");
int By = Convert.ToInt32(ReadLine());
Write("Z = ");
int Bz = Convert.ToInt32(ReadLine());

int X = Bx - Ax, Y = By - Ay, Z = Bz - Az;

double distans = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

WriteLine($"Расстояние между точками {distans:f2}");
