// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Для проверки является ли число палиндромом введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
bool ControlFiveNumbers(int num)
{
    if (num >= 10000 && num <= 99999)
    {
        return true;
    }
    Console.WriteLine("Ошибка! Введено не пятизначное число!");
    return false;
}
int number1 = number / 10000;
int number2 = number / 1000 % 10;
int number5 = number % 10;
int number4 = number / 10 % 10;

bool Palindrome(int n1, int n2, int n4, int n5)
{
    if (n1 == n5 && n2 == n4)
    {
        return true;
    }
    return false;
}
if (ControlFiveNumbers(number))
{
    if (Palindrome(number1, number2, number4, number5))
        Console.WriteLine($"Да,число {number} - палиндром");
    else
        Console.WriteLine($"Нет,число {number} - не палиндром");
}
