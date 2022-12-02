// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N.
// 5 -> 2. 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите цифру ");
string num1 = Console.ReadLine()!;
int n = int.Parse(num1);
int e = 2;
for (int i = e; n >= i; i = i + 2)
{
    Console.WriteLine(i);
}
