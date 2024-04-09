using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevilsGate
{
    public class FinalBoss : ICharacter
    {
        public bool isGameOver = false;
        public bool isDeadBoss = false;
        public bool isAliveBoss = true;
        public int bossHealth = 180;
        public int meeleeDamage = 15;
        public int rangedDamage = 10;
        public int varaibleDamage = 5;
        public bool isBossWinner = false;
        int heal = 5;
        int level = 6;

        public bool IsDead()
        {
            return isDeadBoss;
        }
        public bool IsWinner()
        {
            return isAliveBoss;
        }
        public int GetHealth()
        {
            return bossHealth;
        } 
        public int SetHealth()
        {
            return bossHealth;
        }
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel()
        {
            
        }
        public int GetDamage()
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10);
            if(rndNumber == 1)
            {
                Console.WriteLine("Critical");
                meeleeDamage = (int)rndNumber % 5 + meeleeDamage;
            }
            else if(rndNumber == 2)
            {
                Console.WriteLine("Blocked");
                meeleeDamage = 0;

            }
            else if(rndNumber == 3)
            {
                Console.WriteLine("Life Steal");
                meeleeDamage = new Random().Next(1, 10);
                Console.WriteLine("Boss gave damage " + meeleeDamage);
                meeleeDamage += bossHealth;
            }
            else if(rndNumber == 4)
            {
                Console.WriteLine("Ranged Attack");
                meeleeDamage = 10;
            }
            else
            {
                meeleeDamage = new Random().Next(1, 10);
            }
            return meeleeDamage;
        }
        public void SetDamage()
        {
            meeleeDamage += 2;
            varaibleDamage += 2;
        }
        public int GetHeal()
        {
            bossHealth += heal;
            if( bossHealth > 180 ) 
            {
                bossHealth = 180;
            }
            return bossHealth;
        }
        public int TakeDamage(int damage)
        {
            bossHealth = bossHealth - damage;
            if( bossHealth > 0)
            {
                Console.WriteLine("Boss Died");
                isGameOver = true;
                isDeadBoss = true;
            }
            else
            {
                Console.WriteLine("Boss Health is " + bossHealth);
            }
            return bossHealth;
        }
    }
}
