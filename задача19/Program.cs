//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

int a = number.Length;

if (a == 5)
{
    if (number [0] == number [4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} - не является палиндром");
    }
}
else
{
    Console.WriteLine($"Ошибка, попробуйте еще раз");
}