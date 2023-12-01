//zadanie domowe Dzień 5
int number = 345677251;
string numberAsString = number.ToString();
List<char> digits = numberAsString.ToList();
char[] checkForCounters = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int[] counters = new int[10];
for (int i = 0; i < counters.Length; i++)
{
    counters[i] = 0;
}

foreach (char digit in digits)
{
    for (int j = 0; j < checkForCounters.Length; j++)
    {
        if (digit == checkForCounters[j])
        {
            counters[j]++;
        }
    }
}
Console.WriteLine("W liczbie : "+number);
for (int i = 0; i < counters.Length; i++)
{
    Console.WriteLine("cyfra " + i + " występuje " + counters[i] + " razy");
}