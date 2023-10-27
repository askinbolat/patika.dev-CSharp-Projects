using System;

namespace circle;

public class DrawCircle
{
    public void DrawingCircle()
    {
        Console.Write("Dairenin yarıçapını giriniz  :");
        int yaricap = int.Parse(Console.ReadLine());

        for (double y = -yaricap; y <= yaricap; y ++)
        {
        for (double x = -yaricap; x <= yaricap; x +=0.5)
        {
            if ( (x * x) + (y * y) <= yaricap * yaricap)
                Console.Write("*");
            else
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
