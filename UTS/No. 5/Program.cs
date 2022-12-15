/*
Nama : Stephen Wahyu Oktafianus
NIM : 2207112598
Kelas : Teknik Informatika A
*/


using System;

namespace TicTacToe
{
    class Program
    {
        static char[] Numb = {'0','1','2','3','4','5','6','7','8','9'};
        static int Pemain = 1;
        static int Pilihan;
        static int Mark = 0;

        static void Main(string[] args)
        {
            GamePlay();
        }
        static void GamePlay()
        {
            do
            {
                System.Console.WriteLine("Pemain pertama = X dan Pemain kedua = O\n");
                if (Pemain % 2 == 0)
                {
                    System.Console.WriteLine("Kesempatan Pemain 2\n");
                }
                else
                {
                    System.Console.WriteLine("Kesempatan Pemain 1\n");
                }
                Papan();
                Pilihan = int.Parse(System.Console.ReadLine());
                if (Numb[Pilihan] != 'X' && Numb[Pilihan] != 'O')
                {
                    if (Pemain % 2 == 0)
                    {
                        Numb[Pilihan] = 'O';
                        Pemain++;
                    }
                    else
                    {
                        Numb[Pilihan] = 'X';
                        Pemain++;
                    }
                }
                else
                {
                    System.Console.WriteLine("Maaf baris {0} udah ditandai oleh {1}\n", Pilihan, Numb[Pilihan]);
                }
                Mark = CekMenang();
            }while (Mark != 1 && Mark != -1);
            Papan();
            if (Mark == 1)
            {
                System.Console.WriteLine("Player {0} menang!",( Pemain % 2) + 1);
            }
            else
            {
                System.Console.WriteLine("Imbang");
            }
            System.Console.ReadLine();
        }
        static void Papan()
        {
            System.Console.WriteLine("      |       |      ");
            System.Console.WriteLine("   {0}  |   {1}   |   {2}   ",Numb[1], Numb[2], Numb[3]);
            System.Console.WriteLine("______|_______|______");
            System.Console.WriteLine("      |       |      ");
            System.Console.WriteLine("   {0}  |   {1}   |   {2}   ",Numb[4], Numb[5], Numb[6]);
            System.Console.WriteLine("______|_______|______");
            System.Console.WriteLine("      |       |      ");
            System.Console.WriteLine("   {0}  |   {1}   |   {2}   ",Numb[7], Numb[8], Numb[9]);
            System.Console.WriteLine("      |       |      ");
        }
        static int CekMenang()
        {
            if (Numb[1] == Numb[2] && Numb[2] == Numb[3])
            {
                return 1;
            }
            else if (Numb[6] == Numb[7] && Numb[7] == Numb[8])
            {
                return 1;
            }
            else if (Numb[2] == Numb[5] && Numb[5] == Numb[8])
            {
                return 1;
            }
            else if (Numb[1] == Numb[5] && Numb[5] == Numb[9])
            {
                return 1;
            }
            else if (Numb[1] == '1' && Numb[2] == '2' && Numb[3] == '3' && Numb[4] == '4' && Numb[5] == '5' && Numb[6] == '6' && Numb[7] == '7' && Numb[8] == '8' && Numb[9] == '9')
            {
                return -1;
            }
            else if (Numb[4] == Numb[5] && Numb[5] == Numb[6])
            {
                return 1;
            }
            else if (Numb[1] == Numb[4] && Numb[4] == Numb[7])
            {
                return 1;
            }
            else if (Numb[3] == Numb[6] && Numb[6] == Numb[9])
            {
                return 1;
            }
            else if (Numb[3] == Numb[5] && Numb[5] == Numb[7])
            {
                return 1;
            }
            else if (Numb[7] == Numb[8] && Numb[8] == Numb[9])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
