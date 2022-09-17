

Console.WriteLine("Чтобы узнать день недели введите число от 1 до 7))");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == 1)
{
Console.WriteLine("Понедельник");
}
else if (firstNumber == 2)
{
Console.WriteLine("Вторник");
}
else if (firstNumber == 3)
{
Console.WriteLine("Среда");
}
else if (firstNumber == 4)
{
Console.WriteLine("Четверг");
}
else if (firstNumber == 5)
{
Console.WriteLine("Пятница");
}
else if (firstNumber == 6)
{
Console.WriteLine("Суббота");
}
else if (firstNumber == 7)
{
Console.WriteLine("Воскресенье");
}
else
{
Console.WriteLine("просил число от 1 до 7");
}
