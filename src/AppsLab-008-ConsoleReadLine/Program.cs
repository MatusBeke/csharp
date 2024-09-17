//tvoje meno
Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);

//kolko mas rokov
Console.WriteLine("\nKoľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");

//oblubene jedlo
Console.WriteLine("\nAké je tvoje obľúbené jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine("Mmm " + jedlo + " to znie ako Fifik na hajzli.");
