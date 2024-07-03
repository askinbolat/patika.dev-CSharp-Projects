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
            Console.WriteLine("Bir seçim yapýnýz.\nBarkod Üret (1)\nBarkod Oku (2)\nÇýkýþ (3) ");

            switch (Console.ReadLine())
            {
                
                case "1":
                    Create(); 
                    break;
                case "2":
                    Read(); 
                    break;
                case "3":
                    Console.WriteLine("Oturum kapatýldý.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz bir tercih yaotýnýz.");
                    goto TryAgain;
                    

            }
        }
    }



}
