using System;
using System.Collections.Generic;
using System.Linq;




class NeigbourWarsByMe

{
    static void Main()
    {
        int damagePesho = int.Parse(Console.ReadLine());
        int damageGosho = int.Parse(Console.ReadLine());

        int healthPesho = 100;
        int healthGosho = 100;
        int round = 0;

        string peshoAttack = "Roundhouse kick";
        string goshoAttack = "Thunderous fist";
    

        while (true)
        {
            round++;

            if (round % 2 == 1) // Pesho atack
            {
                healthGosho -= damagePesho;
                if (healthGosho > 0)
                {
                    Console.WriteLine("Pesho used " + peshoAttack + " and reduced Gosho to " + healthGosho + " health.");
                }


            }
            else
            {
                healthPesho -= damageGosho;
                if (healthPesho > 0)
                {
                    Console.WriteLine("Gosho used " + goshoAttack + " and reduced Pesho to " + healthPesho + " health.");
                }

            }

            if (healthPesho <= 0)
            {
                Console.WriteLine("Gosho won in {0}th round.", round);


                break;



            }

            else if (healthGosho <= 0)
            {
                Console.WriteLine("Pesho won in " + round + "th round.");

              break;
            }

            if (round % 3 == 0)
            {
                healthPesho += 10;
                healthGosho += 10;
            }
        }
   }
}

