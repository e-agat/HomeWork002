//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.WriteLine("Введите цифру, обозначающую день недели: ");

int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if(dayOfWeek > 5)
{
    Console.WriteLine("Это выходной!");
}
else
{
    Console.WriteLine("Будний день");
}



