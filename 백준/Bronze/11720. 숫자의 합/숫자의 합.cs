namespace BAEKJOON
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                a += int.Parse(str[i].ToString());
            }

            Console.WriteLine(a);
        }
    }
}