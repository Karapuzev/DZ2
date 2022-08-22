//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


System.Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine($"Ваше второе число {number /10 %10}");