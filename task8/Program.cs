/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int sequence = 2;

while(sequence <= number)
{
    Console.Write($"{sequence} ");
    sequence = sequence + 2;
}