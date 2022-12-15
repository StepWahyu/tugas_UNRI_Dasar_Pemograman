using System;

namespace GameAdventure
{
    class Novice
    {
        public double HealthPoint { get; set; }
        public double Experience { get; set; }
        public int SkillAvaiable { get; set; }
        public int ManaPoint { get; set; }
        public double AttackPower { get; set; }
        public string Name { get; set; }        
        public int levelExp { get; set; }
        public bool isDead { get; set; }
        public double TempPower { get; set; }
        public bool isRunningAway { get; set; }
        public double TempHealPoint { get; set; }
        public double HealPoint { get; set; }
        
        Random randNum = new Random();
        public Novice()
        {
            HealthPoint = 100;
            HealPoint = 1;
            Experience = 0;
            SkillAvaiable = 0;
            ManaPoint = 0;
            AttackPower = 1;
            Name = "NOOB";
            levelExp = 1;
        }
        public void BasicAttack()
        {
            System.Console.WriteLine($"*Slash*");
            TempPower = AttackPower + randNum.Next(3,8);
            SkillAvaiable++;
        }
        public void UltimateAttack()
        {
            System.Console.WriteLine($"Rasakan INI!");
            TempPower = AttackPower + (randNum.Next(3,10) * randNum.Next(2,6));
            SkillAvaiable-= 2;
        }
        public void Gethit(double hitPoint)
        {
            System.Console.WriteLine($"{Name} diserang dengan {hitPoint} ");
            HealthPoint-= hitPoint;

            if (HealthPoint <= 0)
            {
                HealthPoint = 0;
                Dying();
            }
        }
        public void Healing()
        {
            TempHealPoint = HealPoint + randNum.Next(5,36);
            if (HealthPoint >= 100)
            {
                System.Console.WriteLine("Darah Pemain sudah penuh, tidak bisa menambah darah");
            }else
            {
                System.Console.WriteLine($"{Name} Menyembuhkan luka, mendapatkan {TempHealPoint} Point!");
                HealthPoint+= TempHealPoint;
                if (HealthPoint >= 100)
                {
                    HealthPoint = 100;
                }
            }
        }
        public void RunAway()
        {
            System.Console.WriteLine("Kamu lari terpenggal-penggal meninggalkan Arena!");
            isRunningAway = true;
        }
        public void Dying()
        {
            System.Console.WriteLine("Kamu kehabisan darah, Game berakhir.");
            isDead = true;
            System.Console.ReadLine();
        }
    } 
}