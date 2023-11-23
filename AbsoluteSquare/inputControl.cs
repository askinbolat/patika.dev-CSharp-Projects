using System;
using System.Collections.Generic;

namespace Algorithm3
{
    public class inputControl
    {
        public void CheckNumber()
        {
            Console.WriteLine("Girmek istediğiniz sayı adetini giriniz:");
            int input = int.Parse(Console.ReadLine());
            int[] numberArray =new int[input];
            for (int i = 0; i < input; i++)
            {
                Console.Write("Lütfen {1}. sayıyı giriniz:");
                numberArray[i]=int.Parse(Console.ReadLine());
                
            }
            int lowerSum=0;
            int biggerSum=0;
            for (int i = 0; i < input; i++)
            {
                if (numberArray[i]<67)
                {
                    int avarageSum=numberArray[i]-67;
                    lowerSum+=Math.Abs(avarageSum);
                    
                }
                else if (numberArray[i]>67)
                {
                    int avarageSum=numberArray[i]-67;
                    biggerSum+=Math.Abs(avarageSum)*Math.Abs(avarageSum);
                    
                }
            }
            Console.WriteLine(lowerSum);
            Console.WriteLine(biggerSum);
            
        }
    }
}