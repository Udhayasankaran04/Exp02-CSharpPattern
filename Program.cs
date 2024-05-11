using System;
public class Pattern
{
    public static void Main()
    {
    int r=Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<r;i++)
    {
        for(int s=0;s<r-i;s++)
        {
            Console.Write(" ")
            for( int j=0; j<i;j++)
            {
                if(i==0||j==0)
                {
                    c=1;
                }
                else
                {
                    c=c*(i-j+1)/i;
                    Console.Write(c+" ");
                }
            }

        }
    }   
    }
}
