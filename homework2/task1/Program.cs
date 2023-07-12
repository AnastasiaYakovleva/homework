// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int first = number / 100;
int third = number % 10;
int second = (number - third) % 100;
int second1 = second / 10;
string numberReady = ($"Вторая цифра числа {number} – {second1}.");
Console.Write(numberReady);
