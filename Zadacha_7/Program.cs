// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2  918 -> 8

Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
int result = a%10;
if (99 < a && a < 1000) Console.WriteLine(result);
else Console.WriteLine(" Ошибка!!! Введите трехзначное число:");