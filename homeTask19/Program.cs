// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да

// Получаем число и парсим
string? inputNumber = Console.ReadLine();

int inputPol = int.Parse(inputNumber);

int numberP1;
int numberP2;
int numberP3;
int numberP4;
int numberP5;

// Разбираем число по переменным 
void toVar()
{
numberP1 =  inputPol / 10000;
numberP2 = (inputPol / 1000) % 10;
numberP3 = (inputPol / 100) % 10;
numberP4 = (inputPol / 10) % 10;
numberP5 =  inputPol % 10;
}

// Сравниваем переменные
void compareNumber()
{
if(numberP1 == numberP5 && numberP2 == numberP4)
{
    Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Не Полиндром");
}
}
toVar();
compareNumber();