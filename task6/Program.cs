﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/ 

Console.Write("Введите число, чтобы узнать четное ли оно: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if(number % 2 == 0) 
{
    Console.Write("Это четное число");
}
else
{
    Console.Write("Это нечетное число");
}