using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevilsGate
{
    interface ICharacter
    {
        bool IsDead();
        bool IsWinner();
        int GetHealth();
        int SetHealth();
        int GetLevel();
        void SetLevel();
        int GetDamage();
        void SetDamage();
        int GetHeal();
        int TakeDamage(int damage);

    }
    public class Player : ICharacter, IItems, IAbilities
    {
        bool condition = false;
        public bool isDead = false;
        public bool isAlive = true;
        public bool isWinner = true;
        public bool isGameOver = false;
        public int health = 100;
        public int minHealth = 100;
        public int meeleeDamage = 10;
        public int rangedDamage = 6;
        public int heal = 5;
        public int level = 1;
        public Hashtable abilities;
        public Hashtable items;

        public bool IsDead()
        {
            return isDead;
        }
        public bool IsAlive()
        {
            return isAlive;
        }
        public int GetLevel()
        {
            return level;
        }
        public int GetHealth()
        {
            return health;
        }
        public void Updatehealth(int _health)
        {
            health = _health;
        }
        public int SetHealth()
        {
            health += 10;
            return health;
        }
        public int GetDamage()
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10);
            return meeleeDamage;

        }
        public void SetDamage()
        {

        }
        public void SetLevel()
        {
            level += 1;
        }

        
        public bool IsWinner()
        {
            return isWinner;
        }
        public int GetHeal()
        {
            return heal;
        }
        public void SetHeal()
        {
            heal += 5;
            health += heal;
            if (health > 100)
                health = 100;
            Console.WriteLine("Player health is: " + health);
        }
        public int TakeDamage(int damage)
        {
            health -= damage;
            if(health < 0)
             {
                 isDead = true;
                 isAlive = true;
                 isGameOver = true;
              }
              else
                 Console.WriteLine("Player health is: " + health);
            
            return health;
        }
        public void AbilitiesOfPlayer()
        {
            abilities = new()
            {
                { "Critical Hits", 0 },
                { "Blocker", 0 },
                { "Life Steal", 0 },
                { "Ranged Attack", 0 }
            };
            
        }
        public void ItemsOfPlayer()
        {
            items = new()
            {
                { "Bare Hands", 1 },
                { "Sword", 0 },
                { "Shield", 0 },
                { "Armour", 0 },
                { "Bow", 0 }
            };
        }
        public Player()
        {
            AbilitiesOfPlayer();
            ItemsOfPlayer();
        }
    }
}
