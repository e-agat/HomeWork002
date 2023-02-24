//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int firstNum = num / 100;
int remainder = num % 100;
int secondNum = remainder / 10;

if(num > 99 && num < 1000)
{
    Console.WriteLine($"Вторая цифра числа {num}: {secondNum}");
}
else
{
Console.WriteLine("Введено неверное число");
}

