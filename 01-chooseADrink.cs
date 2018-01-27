using System;
using System.Collections.Generic;
using System.Linq;

class ChhoseADrink1
{
    static void Main()
    {
        string person = Console.ReadLine().ToLower();
        string drink = null;
        switch (person)
        {
            case "athlete":  drink = "Water"; break;
            case "businessman":
            case "businesswoman": drink = "Coffee"; break;
            case "softuni student": drink = "Beer"; break;

               

            default:
                drink = "Tea";
                
                break;
               
        }


      Console.WriteLine(drink);


    }
}
