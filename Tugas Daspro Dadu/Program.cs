/*


Tugas Dasar Pemrograman 1
Nama : Stephen Wahyu Oktafianus
NIM : 2207112598
Kelas : Teknik Informatika A


*/

using System;

namespace TugasAduDadu
{
    class Program
    {
        static int userWin = 0;
        static int comWin = 0;
        static int roundNum = 1;
        static int roundLimit = 10;
        static string nickName = "";
        static string playerName = "";
        
        
        
        static void Main(string[] args)
            {   
                Intro();
                NickName();
                while (roundLimit > 0)
                    {
                        GamePlay();
                    }
                End();
                AskPlay();
            }
        

        
        
        
        

        
        static void Intro()
            {
                Console.Clear();
                
                Console.WriteLine("Adu Dadu!\n\nGame ini bertujuan untuk menguji keberuntungan Anda\nAnda akan melawan Komputer sebanyak 10 ronde\nInstruksi bermain:\nKomputer akan Melempar dadu kemudian anda\nJika anda memiliki angka lebih besar dari musuh, maka akan mendapatan 1 poin dan sebaliknya\nJika anda memiliki angka yang sama dengan musuh, maka ronde akan diulang.");
                System.Console.Write("Tekan Enter untuk memulai game!");
                System.Console.ReadLine();
            }
        static void NickName()
            {
                while (nickName == "")
                    {
                        System.Console.Write("Silahkan input nama anda: ");
                        nickName = System.Console.ReadLine();
                    }

                playerName = char.ToUpper(nickName[0]) + nickName.Substring(1);
            }
        static void GamePlay()
            {
                Console.Clear();

                Random num = new Random();

                int user1 = num.Next(1,7);
                int com1 = num.Next(1,7);

                System.Console.WriteLine($"Ronde : {roundNum}\n\nPapan Skor\n{playerName} : {userWin}, Komputer : {comWin}\n");
                System.Console.Write($"Komputer melempar dadu dan mendapat nomor {com1}!\nGiliran {playerName}! ( Tekan Enter untuk melempar dadu! )");
                System.Console.ReadLine();
                System.Console.WriteLine($"\n{playerName} mendapatkan nomor {user1}!\n");
                    
                if (user1 > com1)
                    {
                        System.Console.Write($"{playerName} mencetak 1 poin");
                        userWin++;
                    }
                else if (user1 < com1)
                    {
                        System.Console.Write("Komputer mencetak 1 poin!");
                        comWin++;
                    }
                else
                    {
                        System.Console.Write("Hasilnya seri!");
                        roundLimit++;
                        roundNum--;    
                    }
                
                roundLimit--;
                roundNum++;
                System.Console.ReadLine();
            }

        static void End()
            {
                Console.Clear();

                System.Console.WriteLine($"Ronde berakhir....\n\nHasil akhirnya ialah:\n{playerName} : {userWin}, Komputer : {comWin}\n");
                if (userWin > comWin)
                    {
                        System.Console.WriteLine($"Selamat, {playerName} menang dengan {userWin} skor melawan Komputer!\n");
                    }
                else if (comWin > userWin)
                    {
                        System.Console.WriteLine($"Sayang sekali, {playerName} kalah dengan {userWin} skor melawan Komputer!\n");
                    }
                else
                    {
                        System.Console.WriteLine($"Tidak ada yang menang\n{playerName} dan Komputer memiliki skor yang sama!\n");
                    }
            }
        
        static void AskPlay()
            {
                System.Console.Write($"Apakah {playerName} mau bermain lagi? : (Y/T)");
                
                
                switch (Console.ReadLine().ToUpper())
                {
                    case "Y":
                        userWin = 0;
                        comWin = 0;
                        roundNum = 1;
                        roundLimit = 10;

                        Intro();
                        AskNickName2();

                        while (roundLimit > 0)
                            {
                                GamePlay();
                            }
                        End();
                        AskPlay();
                    break;

                    case ("T"):
                        System.Console.WriteLine("\nTerima kasih telah bermain gim saya!");
                    break;
                
                    default :
                        AskPlay();
                    break;
                }
                static void AskNickName2()
                    {                        
                        System.Console.Write("Apakah anda ingin mengganti nama? (Y/T)");

                        switch (Console.ReadLine().ToUpper())
                            {
                                case "Y":
                                    nickName = "";
                                    playerName = "";
                                    NickName();
                                break;
                                case "T":
                                break;
                                default :
                                    AskNickName2();
                                break;                                
                            }

                    }
            }
    }
}


