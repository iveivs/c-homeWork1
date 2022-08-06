// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    while (i < 8-1)
    {
        Console.Write(numberSintezator.Next(0,10) + ",");
        i++;   
    }
    Console.Write(numberSintezator.Next(0,2));
    Console.Write("]");
}

VariantNaive();