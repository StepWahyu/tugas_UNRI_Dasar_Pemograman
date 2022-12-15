using System;

namespace GameAdventure
{
    class Enemy
    {
        public double HealthPoint { get; set; }
        public double AttackPower { get; set; }
        public string Name { get; set; }
        public bool isDead { get; set; }
        Random randValue = new Random();

        public Enemy()
        {
            HealthPoint = 100;
            //AttackPower = 1;
            Name = "Monster";
        }
        public void Attack()
        {
            AttackPower = randValue.Next(2,15);
        }
        public void Gethit(double hitPoint)
        {
            System.Console.WriteLine($"{Name} terkena serang {hitPoint} Poin");
            HealthPoint = HealthPoint - hitPoint;

            if (HealthPoint <= 0 )
            {
                HealthPoint = 0;
                Dying();
            }
        }
        public void Dying() 
        {
            System.Console.WriteLine($"{Name} telah dikalahkan");
            isDead = true;            
        }
    }
}