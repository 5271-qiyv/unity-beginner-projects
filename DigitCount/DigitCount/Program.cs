namespace DigitCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n=int.Parse(input[0]);
            int x= int.Parse(input[1]);
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                int temp = i;
                while (temp > 0)
                {
                    
                    if(temp% 10 == x)
                    {
                        count++;
                    }
                    temp /= 10;
                }
            }
           
            Console.WriteLine(count);
        }
    }
}
