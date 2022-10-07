// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые, заданные уравнениями y = k1 * x + b1 и y = k2 * x + b2, пересекутся в точке с координатами ({x};{y}).");