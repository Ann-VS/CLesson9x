/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите m: ");
var str = Console.ReadLine() ?? "";
var m = int.Parse(str);
Console.Write("Введите N: ");
str = Console.ReadLine() ?? "";
var n = int.Parse(str);

if (m > n)
{
    Console.WriteLine("Значение m больше n");
    return;
}

var sum = 0;
for (int i = m; i <= n; i++)
    sum += i;

Console.WriteLine($"Сумма равна: {sum}");