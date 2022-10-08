// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number3 = 0;
 if (number < 100)
 {
    Console.WriteLine("третьей цифры нет!!!");
    return;
 }
 else if (number > 100)
 {
    while (number > 1000)
    {
        number = number / 10;
    }
    number3 = number % 10;
 }
 Console.WriteLine ($"Третья цифра = {number3}");