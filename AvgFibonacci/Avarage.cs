using System;

namespace fibonacciAvarage
{
    public class fibonacciAvarage
    {
        public static void Avarage(int depth)
        {
            int[] array =new int[depth];
            int a=0;
            int b=1;
            int c=0;

            array[0]=a;
            array[1]=b;

            for (int i = 2; i < depth; i++)
            {
                c=a+b;
                a=b;
                b=c; 
                array[i]=c;
            }
            double sum=0;
            double avarage=0;
           
            for (int i = 0; i < depth; i++)
            {
                sum+=array[i];
            }
            avarage=sum/depth;
            Console.WriteLine("Girilen derinliğin ortalaması: "+avarage);
        }
    }
}