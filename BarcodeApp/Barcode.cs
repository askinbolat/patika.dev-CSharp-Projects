using System;
using System.IO;

namespace BarcodeApp
{
    partial class Barcode
    {
        string directoryPath, filePath;

        internal Barcode()
        {
            directoryPath = @"C:\BarcodeApp";
            filePath = directoryPath + @"\myBarcode.png";
            Control();
        }

        void Control()
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }



        internal void Begin()
        {
        TryAgain:
            Console.WriteLine("Bir se�im yap�n�z.\nBarkod �ret (1)\nBarkod Oku (2)\n��k�� (3) ");

            switch (Console.ReadLine())
            {
                
                case "1":
                    Create(); 
                    break;
                case "2":
                    Read(); 
                    break;
                case "3":
                    Console.WriteLine("Oturum kapat�ld�.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ge�ersiz bir tercih yaot�n�z.");
                    goto TryAgain;
                    

            }
        }
    }



}
