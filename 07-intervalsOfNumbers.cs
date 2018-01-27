using System;

class intervalsOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        //if (n < m)
        //{
        //    for (int i = n; i <= m; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //else
        //{
        //    for (int i = m; i <= n; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        int minNumber = Math.Min(n, m);
        int maxNumber = Math.Max(n, m);
        for (int i = minNumber; i <= maxNumber; i++)
        {
            Console.WriteLine(i);
        }
   }
}