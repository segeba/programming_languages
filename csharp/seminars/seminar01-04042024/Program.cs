﻿// Console.WriteLine("Input Number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Quad of {a} -> {a * a}");

// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое числоквадратом второго.

// Console.WriteLine("Input Number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine()); //25
// Console.WriteLine("Input Number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine()); //5

// if(num1 == num2 * num2)
// {
//     System.Console.WriteLine($"{num1} is quad of {num2}");
// }
// else
// {
//     System.Console.WriteLine($"{num1} is not quad of {num2}");
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int start = -n;
while (start <= n)
{
    System.Console.Write(start + " ");
    start++;
}