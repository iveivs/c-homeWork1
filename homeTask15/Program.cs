// Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

string? inputNumber = Console.ReadLine();

int inputDay = int.Parse(inputNumber);

if((inputDay == 6 ) || (inputDay == 7))
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будний день");
}

