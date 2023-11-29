//zadanie domowe Dzień 4
var name = "Ewa";
char gender = 'K';
var age = 33;

if (gender == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && gender =='K' && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else  
{
    Console.WriteLine("Nie wiadomo kim jesteś");
}