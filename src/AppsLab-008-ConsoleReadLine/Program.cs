/*//tvoje meno
Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();

//kolko mas rokov
Console.WriteLine("\nKoľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);

//oblubene jedlo
Console.WriteLine("\nAké je tvoje obľúbené jedlo?");
string? jedlo = Console.ReadLine();

//napise vetu o tebe
Console.WriteLine("Ahoj,tvoje meno je " + meno + " máš " + vek + " rokov a tvoje oblúbené jedlo je " + jedlo + ".");*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------

//Operacie 
/*int prveCislo  = 41;
int druheCislo  = 80;

Console.WriteLine(prveCislo + druheCislo);
Console.WriteLine(prveCislo - druheCislo);
Console.WriteLine(prveCislo * druheCislo);
Console.WriteLine(prveCislo / druheCislo);

Console.WriteLine();

Console.WriteLine(10 == 50);
Console.WriteLine(50 == 55);

Console.WriteLine();

Console.WriteLine(10 != 50);
Console.WriteLine(50 != 55);

Console.WriteLine();

Console.WriteLine(10 < 50);
Console.WriteLine(50 > 55);

Console.WriteLine();

Console.WriteLine(10 <= 50);
Console.WriteLine(50 >= 55);

Console.WriteLine();*/

//------------------------------------------------------------------------------------------------------------------------------------------------------




var vysledok = "55" + "10";
Console.WriteLine(vysledok);

//databazy
var menoPouzivatela = "MatusBeke";
var hesloPouzivatela = "123456789";

//Zadanie uzivatelom
var zadanieMeno = "MatusBeke";
var zadanieHeslo = "123456789";

//porovnanie
var porovnanieMeno = menoPouzivatela == zadanieMeno;
var porovnanieHeslo = hesloPouzivatela == zadanieHeslo;

var prijatyPristup = porovnanieHeslo && porovnanieMeno;

//vystup
Console.WriteLine("Meno zhoda: " + porovnanieMeno);
Console.WriteLine("Heslo zhoda: " + porovnanieHeslo);
Console.WriteLine("Povoleny pristup: " + prijatyPristup);

if (prijatyPristup)
{
    Console.WriteLine("Heslo sa zhoduje, vitajte.:D " + menoPouzivatela);
}
else
{
    Console.WriteLine("Vase heslo nie je spravne. :C");
}
