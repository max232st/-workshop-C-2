﻿// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
int first_symbol = number/100;
int last_symbol = number%10;

Console.WriteLine($"Число {number} -> {first_symbol}{last_symbol}");