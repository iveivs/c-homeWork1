// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int m;
// int[] num = new int[m];

int[] ReadNumbers(int m)
{
    int[] mas = new int[m];
    int i = 0;
    while(i < m)
    {
        mas[i] = int.Parse(Console.ReadLine());
    }
    i++;
    return mas;
}

int Calculate(int[] array)
{
    int b = 0;
    int i = 0;
    while(i < array.Length)
        {
        if(array[i] > 0)
            {
                b++;
            }
                i++;
        }
        return b;
}


void PrintResult(int b)
{
    Console.WriteLine(b);
}


Console.WriteLine("Введите количество чисел: ");
m = int.Parse(Console.ReadLine());
int[] buferArray = ReadNumbers(m);
int b = Calculate(buferArray);
PrintResult(b);

