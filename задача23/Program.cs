﻿//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int a = 1;a<=n; a++)
{
    Console.WriteLine ($"Куб числа {a} = {a*a*a}");
}