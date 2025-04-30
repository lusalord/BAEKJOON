namespace BAEKJOON
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a * 2; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < i / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = a * 2 - 1; j >= i; j--)
                    {
                        Console.Write("*");
                    }
                    
                    Console.WriteLine("");
                }
            }
        }

    }
}