// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька

// Метод возвращает массив, заполненный случайными цифрами
int[] FillingArray()
{
    int[] outArray = new int[10];
    // Буферная переменная
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10)
    {
        outArray[i] = numberSintezator.Next(100, 1000);
        // Увеличиваем инкримент
        i++;
    } 
    return outArray;
}

// Печатаем массив
void PrintIntArray(int[] inputArray)
{
    // Буферная переменная
    int i = 0;
    while(i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        // Увеличиваем инкримент
        i++;
    }
    // Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}
// Метод решения задачи 34
int CalculateTask(int[] inputArray)
{
    // Создаём переменную для накопления результата
    int resultCount = 0;
    int i = 0;
    while(i < inputArray.Length)
    {
        if(inputArray[i] % 2 == 0)
        {
            resultCount++;
        }
        i++;
    }
    return resultCount;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int resultOut = CalculateTask(buferArray);
Console.WriteLine(resultOut);