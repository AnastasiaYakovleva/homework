﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, соответствующее дню недели – от 1 до 7. А я скажу, выходной это или нет: ");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7){
    Console.Write($"{number} – да.");
    }
    if (number < 6){
        Console.Write($"{number} – нет.");
        }
        if (number > 7){
            Console.Write("Некорректный ввод.");
            }
