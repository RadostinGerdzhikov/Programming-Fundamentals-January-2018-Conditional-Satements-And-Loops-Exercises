using System;

class DiferentNumbersSecondWay
{
    static void Main()
    {
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        if (max - min < 4)
        {
            Console.WriteLine("No");
        }

     




            for (int firstNum = min; firstNum <= max - 4; firstNum++)
            {
                for (int secondNum = firstNum + 1; secondNum <= max - 3; secondNum++)
                {
                    for (int thirdNum = secondNum + 1; thirdNum <= max - 2; thirdNum++)
                    {
                        for (int fourthNum = thirdNum + 1; fourthNum <= max - 1; fourthNum++)
                        {
                            for (int fifthNum = fourthNum + 1; fifthNum <= max; fifthNum++)
                            {
                                Console.WriteLine($"{firstNum} {secondNum} {thirdNum} {fourthNum} {fifthNum}");
                            }
                        }
                    }
                }
            }

    }    
}