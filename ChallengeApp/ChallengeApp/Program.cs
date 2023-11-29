//zadanie domowe Dzień 4
var name = "Ewa";
char gender = 'K';
var age = 33;
//dodatkowe - weryfikacja wieku
if (age < 18)
{
    Console.WriteLine("Dostęp tylko dla osób pełnoletnich !");
}
else
{
    Console.WriteLine("Zapraszamy");
}
//część główna zadania
if (gender == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (name == "Ewa" && age == 33 )
{
    Console.WriteLine("Ewa, lat 33");
}
if (gender == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}