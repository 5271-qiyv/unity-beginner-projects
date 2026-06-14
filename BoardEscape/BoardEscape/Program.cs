using System;

namespace BoardEscape
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int hx=int.Parse(Console.ReadLine());
            int hy=int.Parse(Console.ReadLine());
            long[,] dp = new long[n + 1, m + 1];
            bool[,] blocked=new bool[n + 1, m + 1];
            if(hx>=0 && hx<n && hy>=0 && hy < m)
            {
                blocked[hx,hy] = true;
            }
            if (hx - 2 >= 0 && hy - 1 >= 0){blocked[hx-2, hy - 1] = true;}
            if (hx - 2 >= 0 && hy + 1 >= 0) { blocked[hx-2,hy+1] = true; }
            if(hx+2>=0&& hy - 1 >= 0) { blocked[hx + 2, hy - 1] = true; }
            if(hx + 2 >= 0 && hy + 1 >= 0) { blocked[hx + 2, hy + 1] = true; }
            if(hx - 1 >= 0 && hy - 2 >= 0) { blocked[hx - 1, hy - 2] = true; }
            if(hx - 1 >= 0 && hy + 2 >= 0) { blocked[hx - 1, hy + 2] = true; }
            if (hx + 1 >= 0 && hy - 2 >= 0) { blocked[hx + 1, hy - 2] = true; }
            if(hx +  1>= 0 && hy + 2 >= 0) { blocked[hx+1, hy+2] = true; }
            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= m; j++)
                {
                    if(i==0 && j == 0)
                    {

                        if (blocked[i, j] == true)
                        {
                            dp[i, j] = 0;
                        }
                        else
                        {
                            dp[i, j] = 1;
                        }
                    }
                    else
                    {
                        if (blocked[i, j] == true)
                        {
                            dp[i, j] = 0;
                        }
                        else
                        {
                            if(i>0) dp[i, j] += dp[i - 1, j];
                            if(j>0) dp[i, j] += dp[i, j - 1];
                        }
                    }
                }
            }
            Console.WriteLine(dp[n, m]);
        }
    }
}