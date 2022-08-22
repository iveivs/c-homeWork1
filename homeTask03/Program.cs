// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет

string? inputA = Console.ReadLine();

if(inputA != null)
{
    int inputNumberA = int.Parse(inputA);
    int outputNumberB = inputNumberA%2;

    if(outputNumberB == 0)
    {
        Console.WriteLine("even");
    }
    else
    {
        Console.WriteLine("odd");
    }

}
