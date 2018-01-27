using System;

class TestNumbers
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        var sum = 0;
        var totalCombination = 0;

        var maxSum = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {

            for (int j = 1; j <= m; j++)
            {
                var number = (i * j) * 3;
                sum += number;

                totalCombination++;
                if (sum >= maxSum)
                {
                    Console.WriteLine($"{totalCombination} combinations");
                    Console.WriteLine($"Sum: {sum} >= {maxSum}");
                    return;

                }

            }

        }

        Console.WriteLine($"{totalCombination} combinations");
        Console.WriteLine($"Sum: {sum}");

    }
}
