// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    
    int startNumber = 2;

    string lineOutput = "";

    while (startNumber < inputNumber)
    {
        lineOutput = lineOutput + startNumber + ", ";

        startNumber = startNumber + 2;

    }

    lineOutput = lineOutput + inputNumber;

   Console.WriteLine(lineOutput);

}
