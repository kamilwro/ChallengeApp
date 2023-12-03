var imię = "Ewa";
var płeć = "Kobieta";
var wiek1 = 33;
var wiek2 = 30;
var wiek3 = 18;


if (imię == "Ewa" && wiek1 == 33)
{
    Console.WriteLine("Ewa, 33 lata");
}
else if (płeć == "Kobieta" && wiek2 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (płeć != "Kobieta" && wiek3 < 18)
{
    Console.WriteLine("Mężczyzna niepełnoletni");
}
