// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Введена неверная цифра. В неделе 7 дней! Введите цифру от 1 до 7:");
} 
else 
    if (number >= 6 && number <= 7)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("нет");
