/* 
Nama : Stephen Wahyu Oktafianus
NIM : 2207112598
Kelas : Teknik Informatika A
*/


using System;

namespace GameAdventure
{
    class Program
    {
        static Novice Pemain = new Novice();
        static Enemy Musuh = new Enemy();
        static Random RandNum = new Random();
        static void Main(string[] args)
        {
            Intro();
            GamePlay();
        }
        static void Intro()
        {
            System.Console.WriteLine("Selamat datang di Game Petualangan\n\nKamu akan melawan setiap monster dihutan sampai kamu Kabur atau Kehabisan Darah\nKamu akan memiliki Level (1-5)\nKamu mendapatkan stamina jika mengurangi darah musuh");
            System.Console.ReadLine();
            AskName();
        }
        static void AskName()
        {
            string TempName = ""; 
            while (TempName == "")
            {
                System.Console.Write("Ketik nama kamu untuk memulai :");
                TempName = Console.ReadLine();
            }
            Pemain.Name = TempName;
        }
        static void GamePlay()
        {
            Console.Clear();
            System.Console.WriteLine($"{Pemain.Name} sedang berkeliling hutan!\n................................\n................................\n{Pemain.Name} bertemu dengan {Musuh.Name}");
            while (!Pemain.isDead && !Musuh.isDead && !Pemain.isRunningAway)
            {
                AskAction();
                if (Musuh.isDead)
                {
                    double TempRandNum = 50;
                    Pemain.Experience+= TempRandNum;
                    System.Console.WriteLine($"{Pemain.Name} mendapatkan {TempRandNum} EXP!");
                    System.Console.ReadLine();
                    Musuh.isDead = false;
                    Musuh.HealthPoint = 100;
                    Pemain.SkillAvaiable = 1;
                    AskLevelUp();
                    GamePlay();
                }
            }
        }
        public static void AskAction()
        {
            System.Console.WriteLine("Silihkan pilih aksi berikut!\n1. Jurus Normal\n2. Jurus Spesial ( Membutuhkan 2 stamina )\n3. Menyembuhkan diri\n4. Kabur");
            switch (Console.ReadLine())
            {
                case "1":
                {
                    Console.Clear();
                    Pemain.BasicAttack();
                    Musuh.Gethit(Pemain.TempPower);
                    Musuh.Attack();
                    Pemain.Gethit(Musuh.AttackPower);
                    System.Console.WriteLine($"Darah {Pemain.Name} : {Pemain.HealthPoint} || Darah {Musuh.Name} : {Musuh.HealthPoint}");
                    break;
                }
                case "2":
                {
                    if (Pemain.SkillAvaiable >= 2)
                    {
                        Console.Clear();
                        Pemain.UltimateAttack();
                        Musuh.Gethit(Pemain.TempPower);
                        Musuh.Attack();
                        Pemain.Gethit(Musuh.AttackPower);
                        System.Console.WriteLine($"Darah {Pemain.Name} : {Pemain.HealthPoint} || Darah {Musuh.Name} : {Musuh.HealthPoint}"); 
                    }
                    else
                    {
                        System.Console.WriteLine($"{Pemain.Name} tidak bisa melakukan kombo ini ( Kamu memiliki {Pemain.SkillAvaiable} Stamina )");
                        AskAction();
                    }
                    break;
                }
                case "3":
                {
                    Console.Clear();
                    Pemain.Healing();
                    Musuh.Attack();
                    Pemain.Gethit(Musuh.AttackPower);
                    System.Console.WriteLine($"Darah {Pemain.Name} : {Pemain.HealthPoint} || Darah {Musuh.Name} : {Musuh.HealthPoint}"); 
                    break;
                }
                case "4":
                {
                    Pemain.RunAway();
                    break;
                }
                default:
                {
                    AskAction();
                    break;
                }
            }
        }
        static void AskLevelUp()
        {
            if (Pemain.Experience == 100 ||Pemain.Experience == 250 ||Pemain.Experience == 450 ||Pemain.Experience == 800 && !Pemain.isRunningAway && !Pemain.isDead)
            {
                LevelUp();
                System.Console.ReadLine();
            }
        }
        static void LevelUp()
        {
            Pemain.levelExp++;
            System.Console.WriteLine($"{Pemain.Name} naik level menjadi level {Pemain.levelExp}");
            switch (Pemain.levelExp)
            {
                case 2 :
                {
                System.Console.WriteLine("Kemampuan Meningkat!\nKemampuan Menyembuhan Meningkat!");
                Pemain.AttackPower = 3;
                Pemain.HealPoint = 3;
                break;
                }
                case 3 :
                {
                System.Console.WriteLine("Kemampuan Meningkat!\nKemampuan Menyembuhan Meningkat!");
                Pemain.AttackPower = 5;
                Pemain.HealPoint = 5;
                break;
                }
                case 4 :
                {
                System.Console.WriteLine("Kemampuan Meningkat!\nKemampuan Menyembuhan Meningkat!");
                Pemain.AttackPower = 7;
                Pemain.HealPoint = 7;
                break;
                }
                case 5 :
                {
                System.Console.WriteLine("Kemampuan Meningkat!\nKemampuan Menyembuhan Meningkat!\nKamu sudah level MAX!");
                Pemain.AttackPower = 10;
                Pemain.HealPoint = 10;
                break;
                }
            }
        }
    }
}
