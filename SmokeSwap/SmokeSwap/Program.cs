namespace SmokeSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int k= int.Parse(Console.ReadLine());
            int temp = n;
            int total = n;
            while (temp>k)
                {
                   total += temp / k;
                temp = temp/k+temp%k;
                }
            Console.WriteLine(total);
        }
    }
}
