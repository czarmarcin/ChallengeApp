//zadanie domowe Dzień 6
using ChallengeApp;

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

if (empl1.Result >= empl2.Result && empl1.Result >= empl3.Result)
{
    int highResult = empl1.Result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl1.Name + " " + empl1.Surname + ", lat" + empl1.Age + " -> " + highResult);
    if (empl1.Result == empl2.Result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl2.Name + " " + empl2.Surname +", lat" + empl2.Age);
    }
    if (empl1.Result == empl3.Result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl3.Name + " " + empl3.Surname + ", lat" + empl3.Age);
    }
}
else if (empl2.Result >= empl1.Result && empl2.Result >= empl3.Result)
{
    int highResult = empl2.Result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl2.Name + " " + empl2.Surname + ", lat" + empl2.Age + " -> " + highResult);
    if (empl2.Result == empl1.Result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl1.Name + " " + empl1.Surname + ", lat" + empl1.Age);
    }
    if (empl2.Result == empl3.Result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl3.Name + " " + empl3.Surname + ", lat" + empl3.Age);
    }
}
else if (empl3.Result >= empl1.Result && empl3.Result >= empl2.Result)
{
    int highResult = empl3.Result;
    Console.WriteLine("Najwięcej punktów zdobył " + empl3.Name + " " + empl3.Surname + ", lat" + empl1.Age + " -> " + highResult);
    if (empl3.Result == empl1.Result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl1.Name + " " + empl1.Surname + ", lat" + empl1.Age);
    }
    if (empl3.Result == empl2.Result)
    {
        Console.WriteLine("Tyle samo zdobył " + empl2.Name + " " + empl2.Surname + ", lat" + empl2.Age);
    }
}
