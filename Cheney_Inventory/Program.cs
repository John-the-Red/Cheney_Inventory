using System;
// John Cheney
// IT112 
// NOTES: The hardest part for me was understanding how to send info to Shipper and how to store and word with the 
// data there. After that most of the code I was able to figure out through my notes and previous lecture recordings
// BEHAVIORS NOT IMPLEMENTED AND WHY: Only thing I don't know if I did it correctly is returning the list of items.
// If there was a way to call them directly from the array then I didn't know what that would look like.

namespace Cheney_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo entry;
            Shipper shipper = new Shipper();
            bool Escape = false;
            do
            {
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");
                entry = Console.ReadKey();
                Console.Clear();
                if (entry.Key == ConsoleKey.NumPad1 || entry.Key == ConsoleKey.D1)
                {
                    IShippable B = new Bicycles("Bicycle",9.50M);
                    shipper.Add(B);
                    Console.WriteLine(shipper.Response());
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (entry.Key == ConsoleKey.NumPad2 || entry.Key == ConsoleKey.D2)
                {
                    IShippable LM = new Lawn_Mowers("Lawn Mower",24.00M);
                    shipper.Add(LM);
                    Console.WriteLine(shipper.Response());
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (entry.Key == ConsoleKey.NumPad3 || entry.Key == ConsoleKey.D3)
                {
                    IShippable BG = new Baseball_Gloves("Baseball Glove",3.23M);
                    shipper.Add(BG);
                    Console.WriteLine(shipper.Response());
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (entry.Key == ConsoleKey.NumPad4 || entry.Key == ConsoleKey.D4)
                {
                    IShippable C = new Crackers("Crackers",0.57M);
                    shipper.Add(C);
                    Console.WriteLine(shipper.Response());
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (entry.Key == ConsoleKey.NumPad5 || entry.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("Shipment manifest:");
                    Console.WriteLine(shipper.AllBicycles());
                    Console.WriteLine(shipper.AllLawn_Mowers());
                    Console.WriteLine(shipper.AllBaseball_Gloves());
                    Console.WriteLine(shipper.AllCrackers());
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (entry.Key == ConsoleKey.NumPad6 || entry.Key == ConsoleKey.D6)
                {
                    Console.WriteLine(shipper.Charges());
                    Console.WriteLine("Press any key to terminate application");
                    Escape = true;
                    Console.ReadKey();
                }
                Console.Clear();
            } while (Escape != true);
        }
    }
}
