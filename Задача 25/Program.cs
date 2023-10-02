// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Ведите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число B");
int B = int.Parse(Console.ReadLine());
double result = Math.Pow(A,B);
Console.WriteLine(result);
