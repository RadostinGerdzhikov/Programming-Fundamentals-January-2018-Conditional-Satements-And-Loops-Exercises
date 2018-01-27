using System;
    
	class MagicLetterByMySelf
    {
        static void Main()
        {

        char startLetter = char.Parse(Console.ReadLine());
        char finalLetter = char.Parse(Console.ReadLine());
        char magicLetter = char.Parse(Console.ReadLine());

        for (char firstL = startLetter; firstL <= finalLetter; firstL++)
        {
            for (char secondL = startLetter; secondL <=finalLetter; secondL++)
            {
                for (char thirthL = startLetter; thirthL <= finalLetter; thirthL++)
                {
                    string word = "" + firstL + secondL + thirthL;

                    if (!word.Contains(magicLetter))
                    {
                        Console.Write(word + " ");

                    }



                }
            }
        }
    }
}
