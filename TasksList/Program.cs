﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Семинар 2:

// №10   Напишите программу, которая принимает на вход трёхзначное число и на выходе
//       показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8

// №13   Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//       что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// №15   Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//       и проверяет, является ли этот день выходным.
// 7 -> да
// 1 -> нет

// Семинар 3:

// №19   Напишите программу, которая принимает на вход пятизначное число и проверяет,
//       является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

// №21   Напишите программу, которая принимает на вход координаты двух точек и находит
//       расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

// Семинар 4

// №25  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
//      натуральную степень B.
//      3, 5 -> 243 (3⁵)
//      2, 4 -> 16
//      * Написать калькулятор с операциями +, -, /, * и возведение в степень


// №27   Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//       452 -> 11
//       82 -> 10
//       * Сделать оценку времени алгоритма через вещественные числа и строки


// №29    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//    * Ввести с клавиатуры длину массива и диапазон значений элементов
//    *Дополнительно: Написать программу которая из имен через запятую выберет случайное
//     имя и выведет в терминал
//     Игорь, Антон, Сергей -> Антон
//     Подсказка: Для разбора строки использовать метод string.split(). Для выбора
//     случайного имени метод Random.Next(1,<длина массива имен>+1). 

// Семинар 5

// №34  Задайте массив заполненный случайными положительными трёхзначными числами.
//      Напишите программу, которая покажет количество чётных чисел в массиве.
//      [345, 897, 568, 234] -> 2
//      [845, 222, 367, 123 -> 1
//      * Отсортировать массив методом пузырька


// №36  Задайте одномерный массив, заполненный случайными числами. Найдите сумму
//        элементов, стоящих на нечётных позициях.
//        [3, 7, 23, 12] -> 19
//        [3, 7, -2, 1] -> 8
//        [-4, -6, 89, 6] -> 0
//        * Найдите все пары в массиве и выведите пользователю


// №38    Задайте массив вещественных чисел. Найдите разницу между максимальным и
//        минимальным элементов массива.
//        [3 7 22 2 78] -> 76
//        [2 0,4 9 7,2 78] -> 77,6
//        * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
//        разницу между первым и последним элементом. Для задачи со звездочкой
//        использовать заполнение массива целыми числами.


// Семинар 6:

// №41   Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
//       пользователь.
//       0, 7, 8, -2, -2 -> 2
//       -1, -7, 567, 89, 223-> 3
//       * Пользователь вводит число нажатий, затем программа следит за нажатиями и
//       выдает сколько чисел больше 0 было введено.


// №43   Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//       уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//       пользователем.
//       b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
//       * Найдите площадь треугольника образованного пересечением 3 прямых


// Семинар 7:

// №47   Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//       m = 3, n = 4.
//       0,5 7 -2 -0,2
//       1 -3,3 8 -9,9
//       8 7,8 -7,1 9
//       * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)


// №50    Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//        возвращает значение этого элемента или же указание, что такого элемента нет.
//        Например, задан массив:
//        1 4 7 2
//        5 9 2 3
//        8 4 2 4
//        17 -> такого числа в массиве нет
//        * Заполнить числами Фиббоначи и выделить цветом найденную цифру


// №52    Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//        Например, задан массив:
//        1 4 7 2
//        5 9 2 3
//        8 4 2 4
//        Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//       * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.


// Семинар 8:

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//            двумерного массива. Например, задан массив:
//            1 4 7 2
//            5 9 2 3
//            8 4 2 4
//            В итоге получается вот такой массив:
//            1 2 4 7
//            2 3 5 9
//            2 4 4 8

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//            строку с наименьшей суммой элементов. Например, задан массив:
//            1 4 7 2
//            5 9 2 3
//            8 4 2 4
//            5 2 6 7
//            Программа считает сумму элементов в каждой строке и выдаёт номер строки
//            с наименьшей суммой элементов: 1 строка


// Задача 58:  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//             Например, заданы 2 массива:
            
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//             5 2 6 7

//             и

//             1 5 8 5
//             4 9 4 2
//             7 2 2 6
//             2 3 4 7

//             Их произведение будет равно следующему массиву:

//             1 20 56 10
//             20 81 8 6
//             56 8 4 24
//             10 6 24 49


// Задача 60.  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//             Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//             массив размером 2 x 2 x 2

//             12(0,0,0) 22(0,0,1)
//             45(1,0,0) 53(1,0,1)


// Задача 62.  Заполните спирально массив 4 на 4.
//             Например, на выходе получается вот такой массив:

//              1 2 3 4
//              12 13 14 5
//              11 16 15 6
//              10 9 8 7


// Задача 64:   Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//              в промежутке от M до N.

//              M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//              M = 4; N = 8. -> ""4, 6, 7, 8""


// Задача 66:   Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//              в промежутке от M до N.

//                M = 1; N = 15 -> 120
//                M = 4; N = 8. -> 30


// Задача 68:     Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//                Даны два неотрицательных числа m и n.

//                m = 2, n = 3 -> A(m,n) = 29