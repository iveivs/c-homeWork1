// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа  или сообщает,
// что третьей цифры нет.

string? inputFirst = Console.ReadLine();

char[] digits = inputFirst.ToCharArray();

if(digits.Length >= 3)
{
    Console.WriteLine(digits[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
