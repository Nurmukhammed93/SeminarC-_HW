// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2,3,7 -> 7
// 44 5 78 - > 78
// 223 9 -> 22
Console.WriteLine("Введите первое число ");
string num1 = Console.ReadLine()!;
int a = int.Parse(num1);
Console.WriteLine("Введите второе число ");
string num2 = Console.ReadLine()!;
int b = int.Parse(num2);
Console.WriteLine("Введите третье число ");
string num3 = Console.ReadLine()!;
int c = int.Parse(num3);
int max = a;

if (max < b) 

{
    max = b;
}
if (max < c)

{
    max = c;
}

Console.WriteLine("max = " + max);

