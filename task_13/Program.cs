// Программа выводит третью цифру заданного числа, или сообщает что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

while (num / 1000 != 0)
{
  num = num / 10;
}
if ((num > 99) || (num < -99))
{
  int num1 = num % 10;
  if(num1 < 0) num1 = num1 * -1;
  Console.WriteLine($"Третья цифра числа: {num1}");
  }
else
{
Console.WriteLine("Третьей цифры нет");
}

