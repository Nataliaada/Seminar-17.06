//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа 
//от 1 до N. 5 -> 2, 48 -> 2, 4, 6, 8


Console.WriteLine("Введите число:");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= b);
 i = i +1;
if (i % 2 ==0) Console.WriteLine($"{i}");
else Console.WriteLine();