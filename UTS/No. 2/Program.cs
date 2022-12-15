/*
Nama : Stephen Wahyu Oktafianus
NIM : 2207112598
Kelas : Teknik Informatika A
*/
using System;

namespace TebakAngka
{
    class Program
    {
        static void Main(string[] args)
        {
            int pNumb = Intro();
            CekJawaban(pNumb);
        }
        static void CekJawaban(int pNum)
        {
            int Guess = 0;
            while (Guess != pNum)
            {
                System.Console.Write("Tebak angka dari 1-100 : ");
                Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess > pNum)
                {
                    System.Console.WriteLine("Salah, nilai terlalu besar");
                }
                else if (Guess < pNum)
                {
                    System.Console.WriteLine("Salah, nilai terlalu kecil");
                }
            }
            System.Console.WriteLine("Anda benar!");
        }
        static int Intro()
        {
            Random pNum = new Random();
            int pNumb = pNum.Next(1,101);
            return pNumb;
        }
    }
}