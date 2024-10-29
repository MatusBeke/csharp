namespace obcan_a_mesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obcan Jakub = new Obcan("Jakub", 15);
            Obcan Matus = new Obcan("Matus", 16);
            Obcan Fero = new Obcan("Fero" , 25);

            Obcan Tono = new Obcan("Jakub", 55);
            Obcan Niko = new Obcan("Matus", 32);
            Obcan Juro = new Obcan("Fero", 96);

            Lekar LekarsBlavy = new Lekar("Jakub", 169);
            Programator ProgrameZBratislavee = new Programator("Matus",555);
            ucitel UcitelZblavy = new ucitel("Gadzo", 33);

            Lekar LekarsKosic = new Lekar("Zelezotrhac", 26);
            Programator ProgrameZKosic = new Programator("Matuzalem", 956);
            ucitel UcitelKosice = new ucitel("Izak", 38);

            Mesto Bratislava = new Mesto("Bratislava");
            Bratislava.PridajObcana(Jakub);
            Bratislava.PridajObcana(Matus);
            Bratislava.PridajObcana(Fero);

            Mesto Kosice = new Mesto("Kosice");
            Kosice.PridajObcana(Tono);
            Kosice.PridajObcana(Juro);
            Kosice.PridajObcana(Niko);

            Console.WriteLine("Obcania BL:");
            Bratislava.VypisObcanov();
            Console.WriteLine("Obcania KE:");
            Kosice.VypisObcanov();
        }
    }
}