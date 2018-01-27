using System;
using System.Collections.Generic;
using System.Linq;




class WordInPlural
{
    static void Main()
    {

        string noun = Console.ReadLine();
        if (noun.EndsWith("y"))
        {
            noun = noun.Remove(noun.Length - 1);
            noun += "ies";
        }
        else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") ||noun.EndsWith("z"))

        {
            noun += "es";
        }
        //o, ch, s, sh, x or z

        else
        {
            noun += "s";
        }



        Console.WriteLine(noun);



    }
}
