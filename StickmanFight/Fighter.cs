using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickmanFight
{
    public class Fighter
    {
        public string name {  get; set; }
        public int Healt { get; set; } = 100;

        public Fighter(string name)
        {
            this.name = name;
        }

        public int Attack1()
        {
            Random random = new Random();
            return random.Next(10, 41);
        }
        public int Attack2()
        {
            Random random = new Random();
            return random.Next(40, 81);
        }
        public int Attack3()
        {
            Random random = new Random();
            return random.Next(80, 95);
        }

        public int Heal()
        {
            Random random = new Random();
            int healValue = random.Next(20, 71);
            if (Healt <= 100)
            {
                if (Healt + healValue > 100)
                {
                    Healt = 100;
                }
                else
                {
                    Healt += healValue;
                }
            }

            return healValue;
        }

        public bool TakeDamage(int damage)
        {
            Healt -= damage;
            if (Healt <= 0)
            {
                Healt = 0;
                return false;
            }
            return true;
        }
    }
}
