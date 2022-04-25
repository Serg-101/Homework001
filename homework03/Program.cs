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
