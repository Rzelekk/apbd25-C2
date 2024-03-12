// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello,  Git!");
Console.WriteLine("Hello,  pjatk!");
Console.WriteLine("Hello,  apbd!");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (double)sum / numbers.Length;
}