//
//
//Задача 3: Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
//
//
Console.Write("Введите число a -> ");
int a = int.Parse(Console.ReadLine());
//   Console.WriteLine(a % 2);
a = a % 2;
if (a == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
