using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RecipeCalculator.Model;
using RecipeCalculator.Utility;

namespace RecipeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RecipeLineItem> recipe1 = new List<RecipeLineItem>();
            recipe1.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe1.Add(new RecipeLineItem(new Lemon(), 1.00f));
            recipe1.Add(new RecipeLineItem(new OrganicOliveOil(), 0.75f));
            recipe1.Add(new RecipeLineItem(new Salt(), 0.75f));
            recipe1.Add(new RecipeLineItem(new Pepper(), 0.50f));

            List<RecipeLineItem> recipe2 = new List<RecipeLineItem>();
            recipe2.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe2.Add(new RecipeLineItem(new ChickenBreast(), 4.00f));
            recipe2.Add(new RecipeLineItem(new OrganicOliveOil(), 0.50f));
            recipe2.Add(new RecipeLineItem(new Vinegar(), 0.50f));

            List<RecipeLineItem> recipe3 = new List<RecipeLineItem>();
            recipe3.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe3.Add(new RecipeLineItem(new Corn(), 4.00f));
            recipe3.Add(new RecipeLineItem(new Bacon(), 4.00f));
            recipe3.Add(new RecipeLineItem(new Pasta(), 8.00f));
            recipe3.Add(new RecipeLineItem(new OrganicOliveOil(), 0.3333f));
            recipe3.Add(new RecipeLineItem(new Salt(), 1.25f));
            recipe3.Add(new RecipeLineItem(new Pepper(), 0.75f));


            // TODO: dlong - could refactor this to a helper(s) for formatting and display
            Console.WriteLine("Recipe 1");
            Console.WriteLine("Tax = {0:C2}", RecipeHelper.CalculateTax(recipe1.ToArray()) / 100.00f);
            Console.WriteLine("Discount = {0:C2}", RecipeHelper.CalculateDiscount(recipe1.ToArray()) / -100.00f);
            Console.WriteLine("Total = {0:C2}", RecipeHelper.CalculateTotal(recipe1.ToArray()) / 100.00f);
            Console.WriteLine();

            Console.WriteLine("Recipe 2");
            Console.WriteLine("Tax = {0:C2}", RecipeHelper.CalculateTax(recipe2.ToArray()) / 100.00f);
            Console.WriteLine("Discount = {0:C2}", RecipeHelper.CalculateDiscount(recipe2.ToArray()) / -100.00f);
            Console.WriteLine("Total = {0:C2}", RecipeHelper.CalculateTotal(recipe2.ToArray()) / 100.00f);
            Console.WriteLine();

            Console.WriteLine("Recipe 3");
            Console.WriteLine("Tax = {0:C2}", RecipeHelper.CalculateTax(recipe3.ToArray()) / 100.00f);
            Console.WriteLine("Discount = {0:C2}", RecipeHelper.CalculateDiscount(recipe3.ToArray()) / -100.00f);
            Console.WriteLine("Total = {0:C2}", RecipeHelper.CalculateTotal(recipe3.ToArray()) / 100.00f);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
