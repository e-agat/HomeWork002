//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Ведите число: ");

int num = Convert.ToInt32(Console.ReadLine());
int firstNum = num;

if(num > 99)

{
    while(firstNum > 999)
{
    firstNum = num / 10;
}
int result = firstNum % 10;
Console.WriteLine($"Третья цифра числа {num}: {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}