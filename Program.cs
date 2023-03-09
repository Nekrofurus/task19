// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Для проверки является ли число палиндромом введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
bool ControlFiveNumbers(int number)
{
    if (number >= 99999 && number < 10000)
    {
        Console.WriteLine("Ошибка! Введено не пятизначное число!");
        return false;
    }
    return true;
}
int n1 = number / 10000;
int n2 = number / 1000 % 10;
int n3 = number % 10;
int n5 = number/10 % 10;
bool Palindrome (int n1, int n2, int n3, int n5)
{
    if (n1 == n5 && n2 == n3)
    {
        Console.WriteLine("Ошибка! Введено не пятизначное число!");
        return false;
    }
    return true;
}
if (ControlFiveNumbers(number))
{
if (Palindrome (n1, n2, n3, n5))
    {
        Console.WriteLine($"Да,число {number}  - палиндром");
    }
    else
    Console.WriteLine($"Нет,число {number}  -  не палиндром");
} 

