// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int count = 1;
for (count = 1; count <= b; count++)
{
    a = a * a;
    count++;
}
Console.WriteLine(a);


