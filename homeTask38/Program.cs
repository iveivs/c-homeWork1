// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

// Метод возвращает массив, заполненный случайными цифрами
int[] FillingArray()
{
    int[] outArray = new int[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10)
    {
        outArray[i] = numberSintezator.Next(-10, 10);
        i++;
    } 
    return outArray;
}

// Печатаем массив
void PrintIntArray(int[] inputArray)
{
    int i = 0;
    while(i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

// Метод решения задачи 38
int CalculateTask(int[] inputArray)
{
    int minNumber = int.MaxValue;
    int maxNumber = 0;
    int i = 1;
    while (i < inputArray.Length)
    {
        if(inputArray[i] > maxNumber)
        {
            maxNumber = inputArray[i];
        }
        if(inputArray[i] < minNumber)
        {
            minNumber = inputArray[i];
        }
        i++;
    }
    return (maxNumber - minNumber);
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int resultOut = CalculateTask(buferArray);
Console.WriteLine(resultOut);