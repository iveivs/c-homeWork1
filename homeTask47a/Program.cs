﻿// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void DoubleArray()
{
    double[,] doubleArray = new double[5, 10];

    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            doubleArray[i, j] = random.NextDouble() * 100; 
            Console.Write("{0,6:F2}", doubleArray[i, j]);
        }
        Console.WriteLine();
    }
 }
DoubleArray();