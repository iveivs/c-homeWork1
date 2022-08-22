// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка


int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSintezator = new System.Random();

    int i = 0;
    int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while(i < countRow)
    {
        j = 0;
        while(j < countColumn)
        {
            outArray[i,j] = numberSintezator.Next(0,10);
            j++;
        }
        i++;
    }
    return outArray;
}

// Метод вывода массива на печать
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;
    while(i < inputArray.GetLength(0))
    {
        j = 0;
        while(j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i,j] + "\t");
            j++;
        }
        // Console.Write("\n")
        Console.WriteLine();
        i++;
    }
}

int FindRow(int[,] a)
{
    int i = 0;
    int j = 0;
    int min = 0;
    int ind = 0;
    while(i < inputArray.GetLength(0))
    {
        j = 0;
        int b = 0;
        while(j < inputArray.GetLength(1))
        {
            b += a[];
            j++;
        }
        if(b < min)
        {
            b = min;
            ind = i;
        }

        i++;
    }
    return ind;
}   

Console.WriteLine(Find);