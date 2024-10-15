using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OOP_Hra
{
    public class Player
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }

        public Player()
        {

        }

        public Player(string name, int attackPower, int hP, int mana)
        {
            Name = name;
            AttackPower = attackPower;
            HP = hP;
            Mana = mana;
        }

        public void DamagePlayer(Player player)
        {
            var HPofEnemy = player.HP;
            int AttackOfCurrentPlayer = this.AttackPower;
            int HPofEnemyAfterFight = HPofEnemy - AttackOfCurrentPlayer;
            player.HP = HPofEnemyAfterFight;

        }
        public void HealPlayer(Player player)
        {
            int ManaOfPlayer = this.Mana;
            int HPofPlayerPlusMana = this.HP + player.Mana;
            this.HP = HPofPlayerPlusMana;
        }
    }
}
