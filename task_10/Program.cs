// Программа принимает трехзначное число и показывает вторую цифру числа.
Console.Clear();
int a = new Random().Next(100, 1000);
Console.WriteLine($"{a}");
int b = a / 10;
int c = b % 10;
Console.WriteLine($"{c}");