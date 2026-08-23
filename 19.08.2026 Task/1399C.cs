using System;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            int[] w = Array.ConvertAll(
                Console.ReadLine().Split(),
                int.Parse
            );

            int[] count = new int[n + 1];

            // Count frequency of each weight
            foreach (int x in w)
            {
                count[x]++;
            }

            int answer = 0;

            // Try every possible team sum
            for (int s = 2; s <= 2 * n; s++)
            {
                int teams = 0;

                for (int x = 1; x <= n; x++)
                {
                    int y = s - x;

                    if (y >= 1 && y <= n)
                    {
                        teams += Math.Min(count[x], count[y]);
                    }
                }

                // Every pair was counted twice
                teams /= 2;

                answer = Math.Max(answer, teams);
            }

            Console.WriteLine(answer);
        }
    }
}