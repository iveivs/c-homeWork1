// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string? inputLineNumberA = Console.ReadLine();

int inputNumberA;
int inputNumberB;

void Conculate()
{
if(inputLineNumberA != null)
{
   inputNumberA = int.Parse(inputLineNumberA);
   inputNumberB = 0;
   while (inputNumberA > 0)
   {
      inputNumberB = inputNumberB + inputNumberA%10;
      inputNumberA = inputNumberA/10;      
   }
   Console.WriteLine(inputNumberB);
}
}
Conculate();