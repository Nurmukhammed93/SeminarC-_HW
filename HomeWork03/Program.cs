// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число ");
string num1 = Console.ReadLine()!;
int num = int.Parse(num1);
int e = num % 2;
int input = 0;


if (e == input)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет!");
}






