/*








Nama : Stephen Wahyu Oktafianus

NIM : 2207112598

Kelas : Teknik Informatika A








*/

using System;

namespace BattleTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjangArea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;

            char[,] playArea = buatRuang(panjangArea, rumput, tank, jumlahTank);

            printArea(playArea, rumput, tank);

            int jumlahTebakanTank = jumlahTank;

            while (jumlahTebakanTank > 0)
            {
                int[] tebakanKoordinat = getKoordinatTebakan(panjangArea);
                char updateTampilanArea = verifikasiTebakan(tebakanKoordinat, playArea, tank, rumput, hit, miss);
                if ( updateTampilanArea == hit )
                {
                    jumlahTebakanTank--;
                }
                playArea = updateArea(playArea, tebakanKoordinat, updateTampilanArea);
                printArea(playArea, rumput, tank);
            }
            System.Console.WriteLine("Game Telah Berakhir!");
            System.Console.Read();
        }
        static char[,] buatRuang(int panjangArea, char rumput, char tank, int jumlahTank)
        {
            char[,] ruangan = new char[panjangArea, panjangArea];

            for (int baris = 0 ; baris < panjangArea ; baris++)
            {
                for (int kolom = 0 ; kolom < panjangArea ; kolom++)
                {
                    ruangan[baris, kolom] = rumput;
                }
            }
            return letakanTank(ruangan, jumlahTank, rumput, tank);
        }
        static char[,] letakanTank(char[,] ruangan, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int panjangArea = 5;

            while (letakTank < jumlahTank)
            {
                int[] lokasiTank = tentukanKoordinatTank(panjangArea);
                char posisi = ruangan[lokasiTank[0], lokasiTank[1]];

                if (posisi == rumput)
                {
                    ruangan[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }
            }
            return ruangan;
        }
        static int[] tentukanKoordinatTank(int panjangArea)
        {
            Random rng = new Random();
            int[] koordinat = new int[2];
            for (int i = 0 ; i < koordinat.Length ; i++)
            {
                koordinat[i] = rng.Next(panjangArea);
            }
            return koordinat;
        }
        static void printArea(char[,] playArea, char rumput , char tank)
        {
            System.Console.WriteLine(" ");

            for (int i = 0 ; i <= 5 ; i++)
            {
                System.Console.Write(i + " ");
            }

            System.Console.WriteLine();

            for (int baris = 0 ; baris < 5 ; baris++)
            {
                System.Console.Write(baris + 1 + " ");
                
                for(int kolom = 0 ; kolom < 5 ; kolom++)
                {
                    char posisi = playArea[baris, kolom];
                    if (posisi == tank)
                    {
                        System.Console.Write(rumput + " ");
                    }
                    else
                    {
                        System.Console.Write(posisi + " ");
                    }
                }
                System.Console.WriteLine();
            }
        }
        private static int[] getKoordinatTebakan(int panjangArea)
        {
            
            int baris;
            int kolom;

            do
            {
                System.Console.Write("Pilih baris (1-5) : ");
                baris = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Pilih Kolom (1-5) : ");
                kolom = Convert.ToInt32(Console.ReadLine());
            }while(kolom <= 0 || baris >= panjangArea + 1 || baris <= 0 || kolom >= panjangArea + 1);
            return new[] {baris - 1, kolom - 1};
        }
        private static char verifikasiTebakan(int[] tebakan, char[,] playArea, char tank, char rumput, char hit, char miss)
        {
            string pesan;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playArea[baris, kolom];

            if (target == tank)
            {
                pesan = "hit";
                target = hit;
            }
            else if (target == rumput)
            {
                pesan = "miss";
                target = miss;
            }
            else
            {
                pesan = "clear";

            }
            System.Console.WriteLine(pesan);
            System.Console.WriteLine();
            return target;
        }
        private static char [,] updateArea(char[,] playArea, int[] tebakanKoordinat, char updateTampilanArea)
        {
            int baris = tebakanKoordinat[0];
            int kolom = tebakanKoordinat[1];
            playArea[baris, kolom] = updateTampilanArea;
            return playArea;
        }
    }
}