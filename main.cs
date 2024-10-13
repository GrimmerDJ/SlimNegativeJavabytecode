using System;

class Program
{
    static void Main()
    {
        string[] salespeople = { "Danielle", "Edward", "Francis" };
        char[] initials = { 'D', 'E', 'F' };
        double[] sales = new double[salespeople.Length];
        char initial;

        do
        {
            Console.Write("Enter salesperson's initial (D, E, F) or Z to quit: ");
            initial = char.ToUpper(Console.ReadKey().KeyChar);  
            Console.WriteLine();  

            if (initial == 'Z')
                break;

            int index = Array.IndexOf(initials, initial);

            if (index != -1)
            {
                Console.Write("Enter the sale amount: ");
                double saleAmount = double.Parse(Console.ReadLine());

                sales[index] += saleAmount;
            }
            else
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
            }

        } while (true);

        double grandTotal = 0.0;
        foreach (double totalSales in sales)
        {
            grandTotal += totalSales;
        }

        Console.WriteLine("\nSales Summary:");
        for (int i = 0; i < salespeople.Length; i++)
        {
            Console.WriteLine($"{salespeople[i]}'s total sales: ${sales[i]:F2}");
        }
        Console.WriteLine($"Grand total sales: ${grandTotal:F2}");

        double highestSales = sales[0];
        string topSalesperson = salespeople[0];

        for (int i = 1; i < sales.Length; i++)
        {
            if (sales[i] > highestSales)
            {
                highestSales = sales[i];
                topSalesperson = salespeople[i];
            }
        }

        Console.WriteLine($"Highest Sale: {topSalesperson}");
    }
}
