using DevilsGate;
using System;
using System.Collections;
using System.Numerics;
namespace Devilsgate
{
    public class Program
    {
        public static List<Enemy> enemyList = new List<Enemy>();
        static void GameMechanics(int level)
        {
            Player player = new Player();
            for(int i=1;i<=level; i++)
            {
                Enemy enemy = new Enemy();
                Console.WriteLine("Fight your enemy");
                do
                {
                    Console.WriteLine("1 : Attack");
                    Console.WriteLine("2 : Heal");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            int damageE = enemy.GetDamage();
                            int damageP = player.GetDamage();
                            enemy.TakeDamage(damageE);
                            player.TakeDamage(damageP);
                            break;
                        case 2:
                            Console.WriteLine("Enemy health is : "+ enemy.GetHealth());
                            player.SetHeal();
                            damageP = player.GetDamage();
                            break;
                    }
                } while(!enemy.IsDead() && !player.IsDead());
                if (player.IsDead())
                {
                    Console.WriteLine("Game Over");
                    return;
                }
                player.SetHealth();
            }
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Enter into the game");
                Console.WriteLine($"You are on floor {i}");
                switch(i)
                {
                    case 1:
                        GameMechanics(i);
                        break;
                    case 2:
                        GameMechanics(i);
                        break;
                    case 3:
                        GameMechanics(i);
                        break;
                    case 4:
                        GameMechanics(i);
                        break;
                    case 5:
                        GameMechanics(i);
                        break;
                    case 6:
                        GameMechanics(i);
                        break;
                }
            } 
        }
    }
}
