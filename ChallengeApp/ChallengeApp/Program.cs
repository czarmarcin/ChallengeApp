//zadanie domowe Dzień 5
int number = 345677;
string numberAsString = number.ToString();
List<char> digits = numberAsString.ToList();

int[] counters = new int[10];
for (int i = 0; i < counters.Length; i++)
{
    counters[i] = 0;
}

foreach (char digit in digits)
{
    if (digit == '0')
    {
        counters[0]++;
    }
    else if (digit == '1')
    {
        counters[1]++;
    }
    else if (digit == '2')
    {
        counters[2]++;
    }
    else if (digit == '3')
    {
        counters[3]++;
    }
    else if (digit == '4')
    {
        counters[4]++;
    }
    else if (digit == '5')
    {
        counters[5]++;
    }
    else if (digit == '6')
    {
        counters[6]++;
    }
    else if (digit == '7')
    {
        counters[7]++;
    }
    else if (digit == '8')
    {
        counters[8]++;
    }
    else if (digit == '9')
    {
        counters[9]++;
    }
}
for (int i = 0; i < counters.Length; i++)
{
    Console.WriteLine("Cyfra " + i + " występuje " + counters[i] + " razy");
}