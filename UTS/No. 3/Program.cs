/*
Nama : Stephen Wahyu Oktafianus
NIM : 2207112598
Kelas : Teknik Informatika A
*/
using System;

namespace DendaPinjaman
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
        }
        static void Intro()
        {
            System.Console.Write("Input jumlah hari peminjaman : ");
            int InputUser = Convert.ToInt32(System.Console.ReadLine());
            int TotalOutput = 0;
            if (InputUser >= 0 && InputUser <= 5)
            {
                TotalOutput = 0;
            }
            else if (InputUser > 5 && InputUser <= 10)
            {
                int Output = 10000;
                InputUser-= 5;
                TotalOutput = Output * InputUser;
            }
            else if (InputUser > 10 && InputUser <= 30)
            {
                int CashM = 50000;
                int Output = 20000;
                InputUser-= 10;
                TotalOutput = CashM + ( Output * InputUser );
            }
            else if (InputUser > 30)
            {
                int CashM = 450000;
                int Output = 30000;
                InputUser-= 30;
                System.Console.WriteLine("Keanggotaan Anda dibatalkan!");
                TotalOutput = CashM + ( Output * InputUser);
            }
            else
            {
                Intro();
            }
            System.Console.Write($"Total denda : {TotalOutput}");
        }
        
    }
}