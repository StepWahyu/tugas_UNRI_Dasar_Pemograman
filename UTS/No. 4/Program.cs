/*
Nama : Stephen Wahyu Oktafianus
NIM : 2207112598
Kelas : Teknik Informatika A
*/
using System;

namespace BatuGutingKertas
{
    class Program
    {
        static int pSkor = 0;
        static int kSkor = 0;
        static bool pRunningAway = false;
        static void Main(string[] args)
        {
            intro();
            GamePlay();
        }
        static void intro()
        {
            System.Console.WriteLine("Batu, Gunting, Kertas\n");
        }
        static void GamePlay()
        {
            while (!pRunningAway)
            {
                Random RanNum = new Random();
                string[] ComChoose = {"Batu", "Gunting", "Kertas"};
                int index = RanNum.Next(ComChoose.Length);
                string KomChoose = ComChoose[index];
                System.Console.Write("Pilih [b]atu, [g]unting, [k]ertas, atau [e]xit");
                string UserInput = System.Console.ReadLine().ToUpper();
                if (UserInput == "B")
                {
                    System.Console.WriteLine($"Komputer Memilih : {KomChoose}");
                    if (KomChoose == "Batu")
                    {
                        System.Console.WriteLine("Kamu imbang!");
                    }
                    else if (KomChoose == "Gunting")
                    {
                        System.Console.WriteLine("Kamu Menang!");
                        pSkor++;
                    }
                    else if (KomChoose == "Kertas")
                    {
                        System.Console.WriteLine("Kamu Kalah!");
                        kSkor++;
                    }
                    System.Console.WriteLine($"Skor pemain : {pSkor}, Skor Komputer : {kSkor}\n");
                    System.Console.Write("Tekan Enter untuk lanjut bermain");
                    System.Console.ReadLine();
                    GamePlay();

                }
                else if (UserInput == "G")
                {
                    System.Console.WriteLine($"Komputer Memilih : {KomChoose}");
                    if (KomChoose == "Batu")
                    {
                        System.Console.WriteLine("Kamu kalah!");
                        kSkor++;
                    }
                    if (KomChoose == "Gunting")
                    {
                        System.Console.WriteLine("Kamu imbang!");
                    }
                    else if (KomChoose == "Kertas")
                    {
                        System.Console.WriteLine("Kamu Menang!");
                        pSkor++;
                    }
                    System.Console.WriteLine($"Skor pemain : {pSkor}, Skor Komputer : {kSkor}\n");
                    System.Console.Write("Tekan Enter untuk lanjut bermain");
                    System.Console.ReadLine();
                    GamePlay();
                }
                else if (UserInput == "K")
                {
                    System.Console.WriteLine($"Komputer Memilih : {KomChoose}");
                    if (KomChoose == "Batu")
                    {
                        System.Console.WriteLine("Kamu benar!");
                        pSkor++;
                    }
                    else if (KomChoose == "Gunting")
                    {
                        System.Console.WriteLine("Kamu Kalah!");
                        kSkor++;
                    }
                    else if (KomChoose == "Kertas")
                    {
                        System.Console.WriteLine("Kamu imbang!");
                    }
                    System.Console.WriteLine($"Skor pemain : {pSkor}, Skor Komputer : {kSkor}\n");
                    System.Console.Write("Tekan Enter untuk lanjut bermain");
                    System.Console.ReadLine();
                    GamePlay();
                }
                else if (UserInput == "E")
                {
                    System.Console.WriteLine("Pemain meninggalkan permainan!");
                    pRunningAway = Exit();
                }
                else
                {
                    GamePlay(); 
                }
            }
        }
        static bool Exit()
        {
            bool pRunningAway = true;
            return pRunningAway;
        }
    }
}