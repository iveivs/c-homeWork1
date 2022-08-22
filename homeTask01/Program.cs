// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10

// Решение:

string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null)
{
    int inputNumberOne = int.Parse(inputLineOne);
    int inputNumberTwo = int.Parse(inputLineTwo);

    if(inputNumberOne > inputNumberTwo)
    {
        Console.WriteLine(inputNumberOne);
    }
    else
    {   
        Console.WriteLine(inputNumberTwo);
    }   
        
    
}
