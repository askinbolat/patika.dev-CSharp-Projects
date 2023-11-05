using System;

namespace characterReverse
{
    public class Reverse
    {
        public void charReverse()
        {
            Console.Write("String bir ifade giriniz: ");
            string input = Console.ReadLine();
            string result="";
            
            for (int i = input.Length-1; i>=0; i--)
            {
                result+=input[i];
                
            }
            string[] resultArray = result.Split(" ");
            Array.Reverse(resultArray);

            foreach (var item in resultArray)
            {
                Console.Write(item+" ");
            }
            

            

           
            
            
        }
    }
}