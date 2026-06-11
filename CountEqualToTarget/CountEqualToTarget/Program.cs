namespace CountEqualToTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int [n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            int m=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == m)
                {
                    Console.WriteLine(arr[i]);
                    return;
                }
                
            }
        }
    }
}
