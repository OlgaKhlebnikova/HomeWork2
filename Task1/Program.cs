﻿//  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
int a = new Random().Next(100,1000);

Console.WriteLine($"Число: {a}");

int b = ((a / 10) % 10);

Console.WriteLine($"Средней цифрой в числе  {a} является {b}" );



