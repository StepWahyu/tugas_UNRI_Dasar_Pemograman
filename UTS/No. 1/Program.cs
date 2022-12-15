/*
Nama : Stephen Wahyu Oktafianus
NIM : 2207112598
Kelas : Teknik Informatika A
*/
using System;

namespace NameTag
{
    class Program
    {
        static void Main(string[] args)
        {

            string namaUser = InputNama();
            string nimUser = InputNIM();
            string konsentrasiUser = InputKonsentrasi();
            PrintArea(namaUser, nimUser, konsentrasiUser);
        }
        static string InputNama()
        {
            System.Console.Write("Nama: ");
            string NameUser = System.Console.ReadLine();
            if (NameUser == "")
            {
                InputNama();
            }
            return NameUser;
        }
        static string InputKonsentrasi()
        {
            
            System.Console.Write("Konsentrasi: ");
            string KonsentrasiUser = System.Console.ReadLine().ToUpper();
            return KonsentrasiUser;
        }
        static string InputNIM()
        {
            System.Console.Write("NIM : ");
            string NIMUser = Console.ReadLine();
            return NIMUser;
        }
        static void PrintArea(string NameUser, string NIMUser, string KonsentrasiUser)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("|***********************************|");
            System.Console.WriteLine("|Nama:{0,30}|",NameUser);
            System.Console.WriteLine("|{0,35}|",NIMUser);
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("|{0,35}|",KonsentrasiUser);
            System.Console.WriteLine("|***********************************|");
        }
    }
}