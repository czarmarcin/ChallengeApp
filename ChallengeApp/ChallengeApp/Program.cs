//zadanie domowe Dzień 6

Empl empl1 = new Empl("Adam", "Słodowy", 44);
Empl empl2 = new Empl("Roman", "Romanowski", 18);    
Empl empl3 = new Empl("Zenobi", "vel Golota",99);

empl1.AddScore(1);
empl1.AddScore(5);  
empl1.AddScore(1);

empl2.AddScore(1);
empl2.AddScore(5);
empl2.AddScore(1);

empl3.AddScore(1);
empl3.AddScore(5);
empl3.AddScore(1);

if (empl1.result >= empl2.result && empl1.result >= empl3.result)
{
    int highResult = empl1.result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl1.name + " " + empl1.surname + "-" + highResult);
    if (empl1.result == empl2.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl2.name + " " + empl2.surname);
    }
    if (empl1.result == empl3.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl3.name + " " + empl3.surname);
    }

}
else if (empl2.result >= empl1.result && empl2.result >= empl3.result)
{
    int highResult = empl2.result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl2.name + " " + empl2.surname + "-" + highResult);
    if (empl2.result == empl1.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl1.name + " " + empl1.surname);
    }
    if (empl2.result == empl3.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl3.name + " " + empl3.surname);
    }
}
else if (empl3.result >= empl1.result && empl3.result >= empl2.result)
{
    int highResult = empl3.result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl3.name + " " + empl3.surname + "-" + highResult);
    if (empl3.result == empl1.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl1.name + " " + empl1.surname);
    }
    if (empl3.result == empl2.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl2.name + " " + empl2.surname);
    }

}
class Empl
{
    private List<int> score = new List<int>();
    public Empl(string name, string surname, int age)
    {
        this.name = name ;
        this.surname = surname ;    
        this.Age = age ;
    }
    public string name { get; private set; }
    public string surname { get; private set; } 
    public int Age { get; private set;}

    public void AddScore(int number)
    {
        this.score.Add(number);
    }
    public int result
    {
        get
        { 
            return this.score.Sum(); 
        }
    }
}