using System;

namespace Consonant
{
    public class ConsonantCheck
    {
        public void ConsonantChecking()
        {
            string consonants ="bcçdfghjklmnprstvyzxw";
            Console.Write("İfadeyi aralarında boşluk bırakarak giriniz: ");
            string[] inputArray =Console.ReadLine().Split(' ');
            string[] boolArray=new string[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray[i].Length-1; j++)      
                {
                    if (consonants.Contains(inputArray[i][j]) && consonants.Contains(inputArray[i][j+1]))
                    {
                        boolArray[i]="True";
                        break;
                    }
                    else
                    {
                        boolArray[i]="False";
                    }
                }
            }
            foreach (var item in boolArray)
            {
                Console.Write(item+" ");
            }
        }
    }
}