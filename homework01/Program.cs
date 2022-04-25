//
//
//Задача 1: Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее,
//a, какое меньшее.
//
//
Console.Write("Введите число a -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b -> ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max = " + a);
}
else
{
    Console.WriteLine("max = " + b);
}