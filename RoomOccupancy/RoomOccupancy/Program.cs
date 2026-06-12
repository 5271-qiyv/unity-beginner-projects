namespace RoomOccupancy
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n=int.Parse(Console.ReadLine());
            int[] rooms = new int[n];
            string[] input= Console.ReadLine().Split(' ');
            int k=int .Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                rooms[i] = int.Parse(input[i]);
            }
            if (rooms[k -1] == 0)
            {
                Console.WriteLine(k);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if(rooms[i] == 0)
                    {
                        Console.WriteLine(i+1);
                        return;
                    }
                }
            }
        }
    }
}
