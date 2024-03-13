// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


static double GetAverage(int[] numbers)
{
    int jeszczeInnaNazwa = 0;
    
    foreach (var number in numbers)
    {
        jeszczeInnaNazwa += number;
    }

    return (double)jeszczeInnaNazwa / numbers.Length;
}

int[] numbers = { 1,2,3,4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbers)
{
    return numbers.Max();
}

Console.WriteLine(GetMax(numbers));