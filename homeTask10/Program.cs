// Напишите программу, которая принимает на вход трёхзначное число,
// и на выходе показывает вторую цифру этого числа.

string? inputFirst = Console.ReadLine();

int inputNumberFirst = int.Parse(inputFirst);

int inputNumberTwo = (inputNumberFirst % 100) / 10;

Console.WriteLine(inputNumberTwo);