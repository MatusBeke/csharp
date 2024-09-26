using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadajte znak pre matematicku operaciu:");
            string operation = Console.ReadLine();
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            double number1final = Double.Parse(number1);
            double number2final = Double.Parse(number2);

            if (operation == "+")
            {
                Console.WriteLine(number1final + number2final);
            }
            else if (operation == "-")
            {
                Console.WriteLine(number1final - number2final);
            }
            else if (operation == "*")
            {
                Console.WriteLine(number1final * number2final);
            }
            else if (operation == "/")
            {
                Console.WriteLine(number1final / number2final);
            }
            else
            {
                Console.WriteLine("Nespravne zadany operator!!!");
            }
        }
    }
}
