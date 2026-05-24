using System;

class Program
{
    static List<string> assets = new List<string>();
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("===IT Asset Management===");
            Console.WriteLine("1. Add Asset");
            Console.WriteLine("2. View Asset");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Choose option");

            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                AddAsset();
                break;

                case "2":
                ViewAssets();
                break;

                case "3":
                running = false;
                Console.WriteLine("Exiting Program....");
                break;

                default:
                 Console.WriteLine("Invalid Option!");
                 break;
            }
            Console.WriteLine();
        }
    }

    static void AddAsset()
    {
        Console.Write("Enter Asset name: ");
        string assetName = Console.ReadLine();

        assets.Add(assetName);

        Console.WriteLine($"Asset '{assetName}' added succesfully.");
    }
    static void ViewAssets()
    {
        Console.WriteLine("===Asset List===");

        foreach(string asset in assets)
        {
            Console.WriteLine(asset);
        }
    }
}
