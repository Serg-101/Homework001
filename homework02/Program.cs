//
//
//Задача 2: Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.
//
//
Console.Write("Введите число a -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b -> ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c -> ");
int c = int.Parse(Console.ReadLine());
int tempmax;
if (a > b)
{
    tempmax = a;
}
else
{
    tempmax = b;
}
if (tempmax > c)
{
    Console.WriteLine("max = " + tempmax);
}
else
{
    Console.WriteLine("max = " + c);
}