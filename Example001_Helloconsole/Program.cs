// See https://aka.ms/new-console-template for more information
Console.Write("Введите число a -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b -> ");
int b = int.Parse(Console.ReadLine());

//int i = Convert.ToInt32(Console.ReadLine());
//bool result = a * a == b
//Console.WriteLine(result ? "Yes" : "No");
// тернарный оператор
a = a * a;
if (a == b)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

Console.Write("Введите номер дня недели -> ");
a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1:
        Console.Write("Понедельник");
        break;
    case 2:
        Console.Write("Вторник");
        break;
    case 3:
        Console.Write("Среда");
        break;
    case 4:
        Console.Write("Четверг");
        break;
    case 5:
        Console.Write("Пятница");
        break;
    case 6:
        Console.Write("Суббота");
        break;
    case 7:
        Console.Write("Воскресенье");
        break;
}



//Console.WriteLine("Квадрат числа -> " + i);
//Console.Write("Квадрат числа -> ");
//Console.WriteLine(i);
//Console.ReadKey();