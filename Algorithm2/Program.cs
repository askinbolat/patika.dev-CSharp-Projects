using System;

namespace algorithm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girmek istediğiniz sayı adetinini giriniz(çift sayıda giriniz)");
            int input= int.Parse(Console.ReadLine());
            string[] inputArray=new string[input];
            for (int i = 0; i < input; i++)
            {
                Console.Write("{0}.sayıyı giriniz:",i+1);
                inputArray[i]=Console.ReadLine();
            }

            for (int i = 0; i < input; i+=2)
            {
                if (inputArray[i]==inputArray[i+1])
                {
                    int number1=int.Parse(inputArray[i]);
                    int number2=int.Parse(inputArray[i+1]);
                    Console.WriteLine(Math.Pow((number1+number2),2));
                }
                else
                {
                    int number1=int.Parse(inputArray[i]);
                    int number2=int.Parse(inputArray[i+1]);
                    Console.WriteLine(number1+number2);
                }
            }
        }
    }
}