using System;

    class CakeIngrdeients
    {
        static void Main()
        {

        string ingredients = Console.ReadLine();

        int current = 0;
        while (ingredients != "Bake!")
        {
            Console.WriteLine("Adding ingredient {0}.", ingredients);
            current++;
            ingredients = Console.ReadLine();
        }
        Console.WriteLine("Preparing cake with {0} ingredients.", current);



        }
    }
