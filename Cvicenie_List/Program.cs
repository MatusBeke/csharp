using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 20;
            numbers[3] = 25;
            numbers[4] = 45;

            Console.WriteLine(numbers[2] + numbers[4]);

            numbers[4] = 10;

            Console.WriteLine(numbers[2] + numbers[4]);
        }
    }
}
