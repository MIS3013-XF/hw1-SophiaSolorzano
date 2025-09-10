// HW1a Sales Total

// Your Name: Sophia Solorzano
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sales tax rate stored in a variable
            double salesTaxRate = 0.085;

            // Prompt user for item
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string item = Console.ReadLine();

            // Prompt for quantity
            Console.WriteLine($"How many {item}'s do you want to buy");
            int quantity = Convert.ToInt32(Console.ReadLine());

            // Prompt for price
            Console.WriteLine($"What is the price for each {item}?");
            double price = Convert.ToDouble(Console.ReadLine());

            // Calculations
            double subtotal = quantity * price;
            double salesTax = subtotal * salesTaxRate;
            double total = subtotal + salesTax;

            // Output results
            Console.WriteLine($"\nYour subtotal for your bill is {subtotal:C2}.");
            Console.WriteLine($"Your sales tax for your bill is {salesTax:C2}.");
            Console.WriteLine($"Your total for your bill is {total:C2}.");

            // Pause program
            Console.ReadKey();

        }
    }
}
