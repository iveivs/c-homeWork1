int coordXPointA;
int coordYPointA;
int coordZPointA;

int coordXPointB;
int coordYPointB;
int coordZPointB;


double lengthAB;


// Считывает координаты точек A и B
void readDataOfPoint()
{
  Console.WriteLine("Введите координату X в точке A");
  coordXPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Y в точке A");
  coordYPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Z в точке A");
  coordZPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату X в точке B");
  coordXPointB = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Y в точке B");
  coordYPointB = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Z в точке B");
  coordZPointB = int.Parse(Console.ReadLine());
}

// Вычисляет растояние между точками А и В
void colculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) + Math.Pow((coordZPointA - coordZPointB),2));
}

readDataOfPoint();
colculateLengthAB();

Console.WriteLine(lengthAB);