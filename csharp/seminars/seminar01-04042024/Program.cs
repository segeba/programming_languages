// Console.WriteLine("Input Number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Quad of {a} -> {a * a}");

// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое числоквадратом второго.

Console.WriteLine("Input Number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine()); //25
Console.WriteLine("Input Number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine()); //5

if(num1 == num2 * num2)
{
    System.Console.WriteLine($"{num1} is quad of {num2}");
}
else
{
    System.Console.WriteLine($"{num1} is not quad of {num2}");
}