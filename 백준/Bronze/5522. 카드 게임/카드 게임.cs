using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        
        for (int i = 0; i < 5; i++)
        {
            int score = int.Parse(Console.ReadLine());
            sum += score;
        }
        
        Console.WriteLine(sum);
    }
}