// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            outArray[i,j] = numberSintezator.Next(0,100);
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
            Console.Write(inputArray[i,j] + " ");
            j++;
        }
        // Console.Write("\n")
        Console.WriteLine();
        i++;
    }
    
}

bool SearchElemTwoDimArray(int[,] inputArray, int el)
{
    int i = 0;
    int j = 0;
    bool result = false;
    while(i < inputArray.GetLength(0))
    {
        j = 0;
        while(j < inputArray.GetLength(1))
        {
            if(inputArray[i,j] == el)
            {
                result = true;
            }
            j++;
        }
        i++;
    }
    return result;
}

void PrintAnswer(bool result)
{
    if(result)
    {
        Console.WriteLine("Элемент найден");
    }
    else
    {
        Console.WriteLine("Элемент не найден");   
    }
}

int[,] twoDimArray = FillTwoDimArray(5,8);
PrintTwoDimArray(twoDimArray);
bool res = SearchElemTwoDimArray(twoDimArray, 17);
PrintAnswer(res);