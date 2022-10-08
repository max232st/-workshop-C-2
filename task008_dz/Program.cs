// Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 1 || number >  7 )
{
    Console.WriteLine("Неверно введен день недели!!!");
    return;
}
if (number == 6 || number == 7)
{
    Console.WriteLine("Ура!!! Выходной!!!");
}
else Console.WriteLine("Пора на работу ");