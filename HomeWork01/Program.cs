// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b=7-> max = 7
// a =2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число ");
string input1 = Console.ReadLine()!;
int a = int.Parse(input1);
Console.WriteLine("Введите второе число ");
string input2 = Console.ReadLine()!;
int b = int.Parse(input2);



if (a > b)
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
if (a < b)
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}
else if (a == b)
{
    Console.WriteLine("max = " + a, b);
}




