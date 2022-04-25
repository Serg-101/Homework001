//----------------------------------------------
// Задача 1
//----------------------------------------------
Console.Write("Введите число n -> ");
int n = int.Parse(Console.ReadLine());
int i;
for (i = n * -1; i <= n; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine(" ");
//----------------------------------------------
// Задача 2
//----------------------------------------------
Console.Write("Введите трехзначное число n -> ");
string s = Console.ReadLine();
    Console.WriteLine(s[2]);
// второй способ решения более правильный
n = int.Parse(Console.ReadLine());
    Console.WriteLine(n % 10);

