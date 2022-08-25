//  Задача 64: 
//
//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  N = 5 -> "5, 4, 3, 2, 1"
//  N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int ReadData()
{
    Console.WriteLine("Задайте число: ");
    return int.Parse(Console.ReadLine());
}

void NaturalNumberPrinter(int num)
{
    // Делаем остановку нашего метода
    if(num == 0) return;
    // Выводим на печать текущее число
    Console.Write(num + " ");
    // Вызываем метод и уменьшаем число на 1
    NaturalNumberPrinter(num-1);
    
}

int inputNumber = ReadData();
NaturalNumberPrinter(inputNumber);
