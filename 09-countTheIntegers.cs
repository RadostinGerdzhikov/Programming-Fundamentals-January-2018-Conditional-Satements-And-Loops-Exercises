using System;

class CountIntegers
{
    static void Main()
    {
        int counter = 0;
        while (true)
        {


            try
            {
                int input = int.Parse(Console.ReadLine());
                //int current = 1;
                counter++;
            }
            catch (Exception)
            {
                break;

            }
        }
        Console.WriteLine(counter);
    }
}
