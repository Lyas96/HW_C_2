// Программа принимает на вход цифру обозначающую день недели и проверяет является ли этот день выходным.
Console.Clear();
Console.Write("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine());
if((day > 0) && (day < 6)) Console.WriteLine("Этот день будний");
if((day > 5) && (day < 8)) Console.WriteLine("Этот день выходной");
if((day < 1) || (day > 7)) Console.WriteLine("Введено неверное число");