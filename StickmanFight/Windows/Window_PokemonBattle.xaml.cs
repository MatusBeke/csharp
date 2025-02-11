﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StickmanFight.Windows
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        //Properties
        public GameEngine gameEngine { get; set; } = new GameEngine();
        public List<string> FightLogger {  get; set; } = new List<string>();
        public Window_PokemonBattle()
        {
            InitializeComponent();

            RefreshElements();
        }
        //Refresher
        public void RefreshElements()
        {
            ProgressBar_Pokemon1_HP.Value = gameEngine.FirstFighter.Healt;
            Label_Pokemon1_HP.Content = gameEngine.FirstFighter.Healt + "/100";

            ProgressBar_Pokemon2_HP.Value = gameEngine.SecondFighter.Healt;
            Label_Pokemon2_HP.Content = gameEngine.SecondFighter.Healt + "/100";

            ListView_FightLog.Items.Clear();
            foreach(var log in FightLogger)
            {
                ListView_FightLog.Items.Add(log);
            }

            if (gameEngine.SecondFighter.Healt <= 0)
            {
                Label_Pokemon2_HP.Content = "Looser!";
                Label_Pokemon1_HP.Content = "Winner!";
            }
            if (gameEngine.FirstFighter.Healt <= 0)
            {
                Label_Pokemon2_HP.Content = "Winner!";
                Label_Pokemon1_HP.Content = "Looser!";
            }

            if(gameEngine.FirstFighter.Healt<= 0 && gameEngine.SecondFighter.Healt <=)
            {
                Button_LightAttcak.IsEnabled = false;
                Button_MediumAttack.IsEnabled = false;
                Button_HardAttack.IsEnabled = false;
            }

        }
        //Light Attack
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.SecondFighter.Attack1();
            var pokemonSurvive = gameEngine.FirstFighter.TakeDamage(damage);
            FightLogger.Add($"{gameEngine.SecondFighter.name} used hard attacked and dealt {damage} damage to {gameEngine.FirstFighter.name}!");

            if (pokemonSurvive)
            {
                AIAttack();
            }

            RefreshElements();
        }
        //Medium Attack
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.SecondFighter.Attack2();
            var pokemonSurvive = gameEngine.FirstFighter.TakeDamage(damage);
            FightLogger.Add($"{gameEngine.SecondFighter.name} used hard attacked and dealt {damage} damage to {gameEngine.FirstFighter.name}!");
            if (pokemonSurvive)
            {
                AIAttack();
            }
            RefreshElements();
        }
        //Hard Attack
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.SecondFighter.Attack3();
            var pokemonSurvive = gameEngine.FirstFighter.TakeDamage(damage);
            FightLogger.Add($"{gameEngine.SecondFighter.name} used hard attacked and dealt {damage} damage to {gameEngine.FirstFighter.name}!");
            if (pokemonSurvive)
            {
                AIAttack();
            }
            RefreshElements();
        }
        //Heal
        private void Heal_Button_Pokemon2_Click(object sender, RoutedEventArgs e)
        {
            var HealValue = gameEngine.SecondFighter.Heal();
            gameEngine.SecondFighter.Heal();
            FightLogger.Add($"{gameEngine.SecondFighter.name} healed with {HealValue}.");
            AIAttack();
            RefreshElements();
        }

        private void AIAttack()
        {
            Random random = new Random();
            var value = random.Next(0, 99);

            if (value > 33)
            {
                var damage = gameEngine.SecondFighter.Attack1();
                var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.FirstFighter.name} used light attacked and dealt {damage} damage to {gameEngine.SecondFighter.name}!");
            }
            else if(value > 33 && value < 69)
            {
                var damage = gameEngine.SecondFighter.Attack2();
                var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.FirstFighter.name} used light attacked and dealt {damage} damage to {gameEngine.SecondFighter.name}!");

            }
            else if (value > 69 && value < 80)
            {
                var damage = gameEngine.SecondFighter.Attack3();
                var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.FirstFighter.name} used light attacked and dealt {damage} damage to {gameEngine.SecondFighter.name}!");
            }
            else if (value >= 80)
            {
                var HealValue = gameEngine.FirstFighter.Heal();
                gameEngine.FirstFighter.Heal();
                FightLogger.Add($"{gameEngine.FirstFighter.name} healed with {HealValue}.");
            }
        }
    }
}
