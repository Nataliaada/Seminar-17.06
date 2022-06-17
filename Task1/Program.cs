// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
//int a = 5;
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
//int b  = 25;
int square = a * a;

if (square == b)
Console.WriteLine("Да");
else Console.WriteLine("Нет");

