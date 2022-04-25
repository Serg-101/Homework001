// See https://aka.ms/new-console-template for more information
Console.Write("Введите число n -> ");
int n = int.Parse(Console.ReadLine());
int i;
for (i = n * -1; i <= n; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine(" ");

Console.Write("Введите трехзначное число n -> ");
string s = Console.ReadLine();
    Console.WriteLine(s[2]);
n = int.Parse(Console.ReadLine());
    Console.Write(n % 10);

