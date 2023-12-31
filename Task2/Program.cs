﻿// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, 
// k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите четыре числа через запятую ");
string[] numbers = Console.ReadLine().Split(", ");
string[] meanings = {"b1", "k1", "b2", "k2"};

for (int i = 0; i < meanings.Length; i++)
Console.Write(String.Join(" ", meanings[i] + " - " + numbers[i] + ", "));
double[] a = new double[meanings.Length];

for (int i = 0; i < numbers.Length; i++){
    a[i] = Convert.ToDouble(numbers[i]);
}

double x = -(a[0] - a[2]) / (a[1] - a[3]);
double y = a[1] * x + a[0];

Console.Write(String.Join(" ", a));
Console.Write($"\nТочка пересечения двух прямых: [{x}, {y}]");