//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6




int numberA = 0, third = 0;
Console.WriteLine("Введите число");
numberA = int.Parse(Console.ReadLine()!);

if(numberA >=100 && numberA <= 999)
{
    third = numberA % 10;
    Console.WriteLine($"Третья цыфра числа {numberA}: {third}");
}
if(numberA >= 99)
{
  Console.WriteLine($"У числа {numberA} нет второй цифры ");
}

if(numberA >= 1000)
{
    int xy = numberA;
    while(xy > 999)
    {
        xy = xy / 10;
    }
    third = xy % 10;

    Console.WriteLine($"Третья цыфра числа {numberA}: {third}");
}