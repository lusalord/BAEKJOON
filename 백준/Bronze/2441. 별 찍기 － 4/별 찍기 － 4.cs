namespace BAEKJOON
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" "); 
                }
                for (int j = a; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
}