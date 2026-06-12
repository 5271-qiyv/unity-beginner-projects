using System;
using System.Collections.Generic;
namespace BoxWeapon
{
    struct Student
    {
        public string Name;
        public List<double> Score;
        public double StdDev;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n_m = Console.ReadLine().Split();
            int n = int.Parse(n_m[0]);
            int m = int.Parse(n_m[1]);
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                students[i].Name = input[0];
                students[i].Score = new List<double>();
                for (int j = 0; j < m; j++)
                {
                    students[i].Score.Add(double.Parse(input[j + 1]));
                }
            }
            for (int i = 0; i < n; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < m; j++)
                {
                    sum += students[i].Score[j];
                }
                double avg = sum / m;
                double v = 0.0;
                double s = 0.0;
                for (int j = 0; j < m; j++)
                {
                    v = students[i].Score[j] - avg;
                    s += v * v;
                }
                students[i].StdDev = Math.Sqrt(s / m);
            }
            Array.Sort(students, (a,b) =>
            {
                if (Math.Abs(a.StdDev - b.StdDev) > 1e-9)
                {
                    return b.StdDev.CompareTo(a.StdDev);
                }
                else
                {
                    return string.Compare(a.Name, b.Name);
                }
            });
            int Count = Math.Min(n, 20);
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(students[i].Name);
            }
        }
    }
}
