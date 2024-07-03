namespace BarcodeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barcode instance = new Barcode();

            while (true) 
            {
                instance.Begin();
            }
        }
    }
}
