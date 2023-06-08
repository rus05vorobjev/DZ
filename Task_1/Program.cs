﻿/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
void Palindrom(int number)
{
if(number >= 10000 && number <= 99999)
{
int division1 = number / 10000;
int remainder1 = number % 10;
 
if(division1 == remainder1)
 {
number = number / 10;
int division2 = (number / 100) % 10;
int remainder2 = number % 10;
if(division2 == remainder2)
Console.WriteLine("Является полиндромом");
}
else 
Console.WriteLine("Не является полиндромом");
            
}
else
Console.WriteLine("Некорректное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
Palindrom(number);
