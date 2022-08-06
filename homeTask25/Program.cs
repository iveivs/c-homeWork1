// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


string? inputLineNumberA = Console.ReadLine();
string? inputLineNumberB = Console.ReadLine();

int inputNumberA;
int inputNumberB;
int outNumber;
int i;

void NumberToPow()
{
if(inputLineNumberA != null && inputLineNumberB != null)
{
    inputNumberA = int.Parse(inputLineNumberA);
    inputNumberB = int.Parse(inputLineNumberB);

    outNumber = (int)Math.Pow(inputNumberA, inputNumberB); 
    Console.WriteLine(outNumber);
}
}

NumberToPow();

void NumberToPow2()
{
    if(inputLineNumberA != null && inputLineNumberB != null)
    {
        inputNumberA = int.Parse(inputLineNumberA);
        inputNumberB = int.Parse(inputLineNumberB);
        i = 0;
        outNumber = 1;
        while (i < inputNumberB)
        {
            outNumber = outNumber * inputNumberA;
            i++;
        }
        Console.WriteLine(outNumber);
    }
}
NumberToPow2();

