using System;


class GameOfNumbers
{
    static void Main()
    {

        int startNumber = int.Parse(Console.ReadLine());
        int endNimber = int.Parse(Console.ReadLine());
        int magicNum = int.Parse(Console.ReadLine());
        int combination = 0;

        int firstLastNum = 0;
        int secondLastNum = 0;

        for (int i = startNumber; i <= endNimber; i++)
        {
            for (int j = startNumber; j <= endNimber; j++)
            {
                combination++;

                if (i + j == magicNum)
                {
                    firstLastNum = i;
                    secondLastNum = j;
                }
            }
        }


        if (firstLastNum + secondLastNum == magicNum)
        {
            Console.WriteLine($"Number found! {firstLastNum} + {secondLastNum} = {magicNum}"); return;
        }


    Console.WriteLine($"{combination} combinations - neither equals {magicNum}");




    }
}