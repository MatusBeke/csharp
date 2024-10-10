using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> store = new List<string>();

            bool isEnd = false; 
            while (!isEnd)
            {
            PrintMenu();
            var answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        foreach (var item in store)
                        {
                            Console.WriteLine(item);    
                        }
                        break;


                    case "2":
                        Console.WriteLine("Zadajte meno noveho predmetu: ");
                        var newItemName = Console.ReadLine() ?? "0";
                        Console.WriteLine("Zadajte kolko kusov noveho predmetu");
                        var newItemCount = Console.ReadLine() ?? "0";
                        AddItem(store, newItemName,Int32.Parse(newItemCount));
                        break;

                    case "3":
                        isEnd = true;
                        break;
        
                    default:
                        Console.WriteLine("Nespravna akcia!");
                        break;
                }
            }
        }

        public static void AddItem(List<string> itemlist, string itemName, int itemCount)
        {
            itemlist.Add(itemName);
        }

        public static void PrintMenu()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("1.Vypis poloziek");
            Console.WriteLine("2.Pridane polozky");
            Console.WriteLine("4.Exit");
            Console.Write("Vyberte akciu:");
        }
    }
}