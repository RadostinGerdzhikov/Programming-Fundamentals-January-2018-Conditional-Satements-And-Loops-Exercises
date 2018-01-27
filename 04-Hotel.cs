using System;

class _04_Hotel
{
    static void Main()
    {
        string month = Console.ReadLine().ToLower();
        int nightsCount = int.Parse(Console.ReadLine());
        double studioPrice = 0.0;
        double doublePrice = 0.0;
        double suitePrice = 0.0;


        switch (month)
        {
            case "may":
            case "october":
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightsCount > 7)
                {
                    studioPrice = studioPrice * 0.95; // strudioPrice *= 0.95; 

                }
                break;
            case "june":
            case "september":
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nightsCount > 14)
                {
                    doublePrice *= 0.90;
                }
                break;
            case "july":
            case "august":
            case "december":
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nightsCount > 14)
                {
                    suitePrice *= 0.85;
                }
                break;
        }


        double totalStudioPrice = studioPrice * nightsCount;
        double totalDoublePrice = doublePrice * nightsCount;
        double totalSuitePrice = suitePrice * nightsCount;

        if (month == "september" || month == "october" && nightsCount > 7)
        {
            totalStudioPrice -= studioPrice;

        }

        Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
        Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
        Console.WriteLine($"Suite: {totalSuitePrice:F2} lv. ");


    }
}