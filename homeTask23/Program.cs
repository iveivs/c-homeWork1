// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNN = string.Empty;
    int s = 1;
    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNN = lineNN + (s * s * s).ToString() + " ";
        s++;
    }
   Console.WriteLine(lineN);
   Console.WriteLine(lineNN);

}