namespace Cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Bača Jano", 150, 1500, 60);
            Player player2 = new Player("Zemepán Nikolaj Palfi", 100, 1950, 40);

            while (player2.HP >= 0 && player1.HP >= 0) 
            {
                Console.WriteLine("Player2 HP: " + player2.HP);
                player1.DamagePlayer(player2);
                Console.WriteLine("Player2 HP afret Fight: " + player2.HP);
                player1.HealPlayer(player1);

                Console.WriteLine("Player1 HP: " + player1.HP);
                player2.DamagePlayer(player1);
                Console.WriteLine("Player1 HP afret Fight: " + player1.HP);
                player2.HealPlayer(player2);
            }
            if (player1.HP >= player2.HP)
            {
                Console.WriteLine("Player1 is winner!");
            }
            else
            {
                Console.WriteLine("Player2 is winner");
            }
        }
    }
}