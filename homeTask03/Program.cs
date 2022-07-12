string? inputA = Console.ReadLine();

if(inputA != null)
{
    int inputNumberA = int.Parse(inputA);
    int outputNumberB = inputNumberA%2;

    if(outputNumberB == 0)
    {
        Console.WriteLine("even");
    }
    else
    {
        Console.WriteLine("odd");
    }

}
