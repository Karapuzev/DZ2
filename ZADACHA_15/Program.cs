//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.




System.Console.Clear();

System.Console.WriteLine("Введите номер дня недели:");
int day = int.Parse(Console.ReadLine()!);

if(day >= 6 && day < 8)
{
System.Console.WriteLine("Да выходной день");
}
else
{
System.Console.WriteLine("Нет рабочий день");
}