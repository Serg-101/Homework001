﻿//
//
//Задача 4: Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.
//
//
Console.Write("Введите число a -> ");
int a = int.Parse(Console.ReadLine());
if (a >= 2)
{
    Console.Write(2);    
}
//Делаем проверку, что бы убрать последние запятые
int i;
for (i = 3; i < a; i++)
{
    i++;
    Console.Write(", " + i);
}