// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

// Метод возвращает массив, заполненный случайными цифрами
int[] FillingArray()
{
    int[] outArray = new int[10];
    // Буферная переменная
    int i = 0;
    // Создаём экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    // Создаём цикл заполнения массива
    while (i < 10)
    {
        outArray[i] = numberSintezator.Next(-10, 10);
        // Увеличиваем инкримент
        i++;
    } 
    // Возвращаем значение
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

// Метод решения задачи 36
int CalculateTask(int[] inputArray)
{
    int sumNumber = 0;
    int i = 1;
    while (i < inputArray.Length)
    {
        sumNumber = sumNumber + inputArray[i];
        i += 2;
    }
    return sumNumber;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int resultOut = CalculateTask(buferArray);
Console.WriteLine(resultOut);