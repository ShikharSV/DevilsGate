using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevilsGate
{
    public class Enemy : ICharacter
    {
        bool condition = false;
        public bool isDeadEnemy = false;
        public bool isAliveEnemy = true;
        public int enemyHealth = 100;
        public int meeleeDamageEnemy = 15;
        public int rangedDamageEnemy = 10;
        public int varaibleDamageEnemy = 5;
        public bool isEnemyWinner = false;
        
        int heal = 5;
        int level = 1;
        public bool IsDead()
        {
            return isDeadEnemy;
        }
        public bool IsWinner()
        {
            return isAliveEnemy;
        }
        public int GetHealth()
        {
            return enemyHealth;
        }
        public int SetHealth()
        {
            enemyHealth += 10;
            return enemyHealth;
        }
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel()
        {
            level++;
        }
        public int GetDamage()
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10);
            if (rndNumber >2 && rndNumber < 6)
            {
                Console.WriteLine("Enemy defended");
                meeleeDamageEnemy = 0;
            }
            else
            {
                meeleeDamageEnemy = new Random().Next(1, 15);
            }
            return meeleeDamageEnemy;
        }
        public void SetDamage()
        {
            meeleeDamageEnemy += 2;
            varaibleDamageEnemy += 2;
        }
        public int GetHeal()
        {
            enemyHealth += heal;
            if (enemyHealth > 100)
            {
                enemyHealth = 100;
            }
            return enemyHealth;
        }
        public int TakeDamage(int damage)
        {
            enemyHealth = enemyHealth - damage;
                if (enemyHealth < 0)
                {
                    isAliveEnemy = false;
                    isDeadEnemy = true;
                }
                else
                {
                    Console.WriteLine("Enemy Health is : " + enemyHealth);
                }
            
            return enemyHealth;
        }
    }
}
