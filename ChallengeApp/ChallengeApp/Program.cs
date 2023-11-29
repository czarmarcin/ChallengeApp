//zadanie domowe Dzień 4
using System.ComponentModel.Design;

var name = "Ewa";
char gender = 'M';
var age = 120;
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
else if (gender == 'M' && age < 60) 
{
    Console.WriteLine("Dojrzały mężczyzna");
}
else if (gender == 'M' && age < 120) 
{
    Console.WriteLine("Starszy mężczyzna");
}
else if (gender == 'M' && age >= 120) 
{
    Console.WriteLine("Nie ma takiej opcji");
}