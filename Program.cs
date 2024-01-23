using System;
public class SumExample
{
    public static void Main(string[] args)
    {
        int n, sum = 0, m;
        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n > 0)   //123   
        {
            m = n % 10;      //m=3 m=2 m=1 
            sum = sum + m;  //sum=3 sum=3+2=5 sum=3+2+1=6 
            n = n / 10;      //n=12 n=1 
        }
        Console.Write("Sum is= " + sum);
    }
}