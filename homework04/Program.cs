Console.Write("Введите число a -> ");
int a = int.Parse(Console.ReadLine());
if (a >= 2)
{
    Console.Write(2);    
}
int i;
for (i = 3; i < a; i++)
{
    i++;
    Console.Write(", " + i);
}