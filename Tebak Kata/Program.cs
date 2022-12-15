/*



Nama = Stephen Wahyu Oktafianus
NIM = 2207112598
Kelas = Teknik Informatika A




*/



using System;
using System.Collections.Generic;

namespace DasproTebakkata
{
    class Program
    {
        static string misteryName = "AKUNTANSI";
        static int roundLimit = 5;
        static List<string> tebakanAnda = new List<string>{};
        static void Main(string[] args)
        {
            Intro();
            GamePlay();
        }

        static void Intro()
        {
            System.Console.WriteLine($"Tebak Kata!\n\nSelamat Datang, hari ini kita akan bermain tebak kata..\nKamu mempunyai {roundLimit} kesempatan untuk menebak kata misteri hari ini!\nPetunjuknya adalah kata ini merupakan nama film animasi.\nKata ini terdiri dari {misteryName.Length} karakter.\nFilm apakah yang dimaksud?");
            System.Console.ReadKey();
        }
        static void GamePlay()
        {
            
            while (roundLimit > 0)
            {
                System.Console.Write("Pilih kata dari A sampai Z:");
                string input =  Console.ReadLine().ToUpper();
                tebakanAnda.Add(input);

                if (cekjawaban(misteryName, tebakanAnda))
                {
                    System.Console.WriteLine($"Selamat anda berhasil\nKata misteri hari ini adalah {misteryName}");
                    break;
                }
                else if (misteryName.Contains(input))
                {
                    System.Console.WriteLine("Huruf itu ada di dalam kata ini\nSilahkan tebak huruf lain...");
                    System.Console.WriteLine(cekhuruf(misteryName, tebakanAnda));
                }
                else
                {
                    System.Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    roundLimit--;
                    System.Console.WriteLine($"Kesempatan mencoba tinggal {roundLimit}!");
                }
            }
            if (roundLimit == 0)
            {
                System.Console.WriteLine("Maaf kesempatan mu telah habis!");
            }  

            


            

        }
        static bool cekjawaban(string misteryName, List<string> tebakanAnda)
        {
            bool status = false;
            for (int i = 0 ; i < misteryName.Length ; i++)
            {
                string c = Convert.ToString(misteryName[i]);
                if (tebakanAnda.Contains(c))
                {
                    status = true;
                }
                else
                {
                    status = false;
                    return status;
                }
            }
            return status;
        }
        static string cekhuruf(string misteryName, List<string> tebakanAnda)
        {
            string x = "";
            for (int i = 0; i < misteryName.Length; i++)
            {
                string c = Convert.ToString(misteryName[i]);
                if (tebakanAnda.Contains(c))
                {
                    x = x + c ;
                }
                else
                {
                    x = x + "_";
                }
            }
            return x;
        }
        
    }
}