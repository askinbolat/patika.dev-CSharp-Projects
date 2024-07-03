using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;

namespace BarcodeApp
{

    partial class Barcode
    {
        void Create()
        {
            try 
            {
                Console.WriteLine("Metin giriniz");
                GeneratedBarcode myBarcode = BarcodeWriter.CreateBarcode(Console.ReadLine(), BarcodeWriterEncoding.EAN8);
                myBarcode.SaveAsImage(filePath);
                Console.WriteLine("Barkod başarıyla üretildi");

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Geçersiz format");
            }
        }

        void Read()
        {
            try
            {
                Console.WriteLine("Barkod okunuyor.");

                BarcodeResult[] results = BarcodeReader.Read(filePath).ToArray();
                Console.WriteLine(results[0].Text);
                Console.WriteLine("Barkod okundu.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Barkod bulunamadı");
            }
        }
    }
}
