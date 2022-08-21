// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

int[,] Filter(int[,] inArray)
{
    
    int i = 0;
    int j = 0;
    while(i < inputArray.GetLength(0))
    {
        j = 0;
        int[] b = 0;
        while(j < inputArray.GetLength(1))
        {
            b = inArray
            j++;
        }
        b = Sort(b)
        // Метод сортировки массива(на уроке мы такое не проходили, поэтому нашёл в интернете)
        // int[] Sort(int[] b)
        // int temp;
        // for (int i = 0; i < nums.Length - 1; i++)
        // {  
        //     for (int j = i + 1; j < nums.Length; j++)
        //     {
        //         if (nums[i] > nums[j])
        //         {
        //             temp = nums[i];
        //             nums[i] = nums[j];
        //             nums[j] = temp;
        //         }
        //     }
        // }
        j = 0;
        while(j < inputArray.GetLength(1))
        {
            inArray = b
            j++;
        }
        i++;
    }
    return ;
}

int[,] twoDimArray = FillTwoDimArray(5,8);
PrintTwoDimArray(twoDimArray);
Filter(twoDimArray);