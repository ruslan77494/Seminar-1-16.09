// Число в квадрате
Console.WriteLine("Пожалуйста введите число : ");

string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

int result = number * number;

Console.WriteLine($"Число: {number}. Квадрат: {result}");
