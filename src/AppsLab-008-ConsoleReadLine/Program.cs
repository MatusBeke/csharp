//tvoje meno
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
Console.WriteLine("Ahoj,tvoje meno je " + meno + " máš " + vek + " rokov a tvoje oblúbené jedlo je " + jedlo + ".");