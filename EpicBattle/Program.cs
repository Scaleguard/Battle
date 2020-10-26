using System;
using System.Runtime.Serialization;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Bilbo Baggins", "Lara Croft" };
            string[] villains = { "Voldemort", "Darth Vader", "Sauron", "Joker", "Harley Quinn" };

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            Console.WriteLine($"{hero} will fight {villain}");

            
            int heroHP = GenerateHP();
            int villainhp = GenerateHP();
            Console.WriteLine($"{hero} with {heroHP} HP will fight {villain} wih" + $" {villainhp} HP");

            while(heroHP > 0 && villainhp > 0)
            {
                heroHP = heroHP - Hit(hero);
                villainhp = villainhp - Hit(villain);
            }

            GetWinner(heroHP, villainhp);
        }

        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;

        } 

        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;

        }

        public static int Hit(string character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character} hit {strike}!");
            if(strike == 3)
            {
                Console.WriteLine($"Awesome! {character} made a critical hit!");
            }else if(strike == 0)
            {
                Console.WriteLine($"Bad Luck! {character} missed the target!");
            }
            return strike;
        }

        public static void GetWinner(int hHP, int vHP)
        {
           if(hHP == 0)
           {
                Console.WriteLine("The Forces of evil have won");

           }
           else
           {
                Console.WriteLine($"Hero saves the day");
           }
        }
    }
}
