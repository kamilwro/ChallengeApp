var name = "Ewa";
var gender = "Kobieta";
var age1 = 33;
var age2 = 30;
var age3 = 18;


if (name == "Ewa" && age1 == 33)
{
    Console.WriteLine("Ewa, 33 lata");
}
else if (gender == "Kobieta" && age2 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender != "Kobieta" && age3 < 18)
{
    Console.WriteLine("Mężczyzna niepełnoletni");
}
