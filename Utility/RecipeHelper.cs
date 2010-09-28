using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RecipeCalculator.Model;

namespace RecipeCalculator.Utility
{
    public static class RecipeHelper
    {
        private const float DISCOUNT_PERCENTAGE = 0.95f;
        private const float TAX_RATE = 0.086f;

        public static int CalculateTax(RecipeLineItem[] input)
        {
            int output = 0;

            foreach (RecipeLineItem rli in input)
            {
                float extendedPrice = CalculateIngredientExtendedPrice(CalculateIngredientDiscountedPrice(rli.Ingredient), rli.Units);
                int tax = CalculateIngredientTax(rli.Ingredient, extendedPrice);

                output += tax;
            }

            return output;
        }

        public static int CalculateDiscount(RecipeLineItem[] input)
        {
            float regularPrice = 0.0f;
            float discountedPrice = 0.0f;

            foreach (RecipeLineItem rli in input)
            {
                regularPrice += CalculateIngredientExtendedPrice((float)rli.Ingredient.Cost, rli.Units);
                discountedPrice += CalculateIngredientExtendedPrice(CalculateIngredientDiscountedPrice(rli.Ingredient), rli.Units);
            }

            return (int)Math.Round(regularPrice - discountedPrice, MidpointRounding.AwayFromZero);
        }

        public static int CalculateTotal(RecipeLineItem[] input)
        {
            float totalPrice = 0.0f;
            int tax = 0;

            foreach (RecipeLineItem rli in input)
            {
                float extendedPrice = CalculateIngredientExtendedPrice(CalculateIngredientDiscountedPrice(rli.Ingredient), rli.Units);
                tax += CalculateIngredientTax(rli.Ingredient, extendedPrice);
                totalPrice += extendedPrice;
            }

            return tax + (int)Math.Round(totalPrice, MidpointRounding.AwayFromZero);
        }


        // TODO: dlong - refactor into extension methods?
        public static int CalculateIngredientDiscountAmount(RecipeIngredientBase input)
        {
            if (input.IsOrganic)
            {
                return input.Cost - (int)Math.Round(CalculateIngredientDiscountedPrice(input), MidpointRounding.AwayFromZero);
            }
            else
            {
                return 0;
            }
        }

        public static float CalculateIngredientDiscountedPrice(RecipeIngredientBase input)
        {
            if (input.IsOrganic)
            {
                return input.Cost * DISCOUNT_PERCENTAGE;
            }
            else
            {
                return (float)input.Cost;
            }
        }

        public static float CalculateIngredientExtendedPrice(float discountedCost, float units)
        {
            return discountedCost * units;
        }

        public static int CalculateIngredientTax(RecipeIngredientBase input, float extendedPrice)
        {
            if (input.IsProduce)
            {
                return 0;
            }
            else
            {
                // HACK: dlong - for review - Not sure why we'd take the ceiling here but based on the supplied data/unit tests
                // this is what needs to happen to make it work

                //int tax = (int)Math.Round(extendedPrice * TAX_RATE, MidpointRounding.AwayFromZero);
                int tax = (int)Math.Ceiling(extendedPrice * TAX_RATE);

                while (tax % 7 != 0)
                {
                    tax += 1;
                }

                return tax;
            }
        }
    }
}
