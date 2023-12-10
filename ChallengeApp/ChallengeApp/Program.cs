//zadanie domowe Dzień 6
Empl empl1 = new Empl("Adam", "Słodowy", 44);
Empl empl2 = new Empl("Roman", "Romanowski", 18);    
Empl empl3 = new Empl("Zenobi", "vel Golota",99);

empl1.AddScore(1);
empl1.AddScore(2);  
empl1.AddScore(3);
empl1.AddScore(4);
empl1.AddScore(5);

empl2.AddScore(1);
empl2.AddScore(2);
empl2.AddScore(3);
empl2.AddScore(4);
empl2.AddScore(5);

empl3.AddScore(1);
empl3.AddScore(2);
empl3.AddScore(3);
empl3.AddScore(4);
empl3.AddScore(0);

if (empl1.result >= empl2.result && empl1.result >= empl3.result)
{
    int highResult = empl1.result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl1.Name + " " + empl1.Surname + ", lat" + empl1.Age + " -> " + highResult);
    if (empl1.result == empl2.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl2.Name + " " + empl2.Surname +", lat" + empl2.Age);
    }
    if (empl1.result == empl3.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl3.Name + " " + empl3.Surname + ", lat" + empl3.Age);
    }

}
else if (empl2.result >= empl1.result && empl2.result >= empl3.result)
{
    int highResult = empl2.result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl2.Name + " " + empl2.Surname + ", lat" + empl2.Age + " -> " + highResult);
    if (empl2.result == empl1.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl1.Name + " " + empl1.Surname + ", lat" + empl1.Age);
    }
    if (empl2.result == empl3.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl3.Name + " " + empl3.Surname + ", lat" + empl3.Age);
    }
}
else if (empl3.result >= empl1.result && empl3.result >= empl2.result)
{
    int highResult = empl3.result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl3.Name + " " + empl3.Surname + ", lat" + empl1.Age + " -> " + highResult);
    if (empl3.result == empl1.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl1.Name + " " + empl1.Surname + ", lat" + empl1.Age);
    }
    if (empl3.result == empl2.result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl2.Name + " " + empl2.Surname + ", lat" + empl2.Age);
    }

}
class Empl
{
    private List<int> score = new List<int>();
    public Empl(string name, string surname, int age)
    {
        this.Name = name ;
        this.Surname = surname ;    
        this.Age = age ;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; } 
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