using System;

class ResaturantDiscount
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string package = Console.ReadLine().ToLower();
        string hallName = null;
        double discount = 0.0;
        double pricePakcage = 0.0;
        double totalPice = 0.0;
        double pricePerPerson = 0.0;
        double hallPrice = 0.0;

        if (groupSize < 51)
        {
           hallName  = "Small Hall";
            hallPrice = 2500;

            switch (package)
            {
              case "normal":
                    discount = 0.95;
                    pricePakcage = 500;
                                 break;
                case "gold":
                    discount = 0.90;
                    pricePakcage = 750;
                    break;
                case "platinum":
                    discount = 0.85;
                    pricePakcage = 1000;
                    break;
 
            }

            //totalPice = (2500 + pricePakcage) * discount;
        }
        else if (groupSize < 101 )
        {
            hallName = "Terrace";
            hallPrice = 5000;

            switch (package)
            {
                case "Small Hall":
                    pricePakcage = 750;
                    discount = 0.9;
                    break;
                case "gold":
                    pricePakcage = 750;
                    discount = 0.9;
                    break;
                case "platinum":
                    pricePakcage = 1000;
                    discount = 0.85;break;
            }
           // totalPice = (5000 + pricePakcage) * discount;


        }
        else if (groupSize < 120)
        {
            hallName = "Great Hall";
            hallPrice = 7500;
            switch (package)
            {

                case "normal":
                    pricePakcage = 500;
                    discount = 0.95;
                    break;
                case "gold":
                    pricePakcage = 750;
                    discount = 0.9; break;
                case "platinum":
                    pricePakcage = 1000;
                    discount = 0.85;
                    break;
            }
           // totalPice = (hallPrice + pricePakcage) * discount;
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }
        totalPice = (hallPrice + pricePakcage) * discount;
        pricePerPerson = totalPice / groupSize;

        Console.WriteLine($"We can offer you the {hallName}");
        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
    }
}

