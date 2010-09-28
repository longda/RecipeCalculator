using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCalculator.Model
{
    public class RecipeLineItem 
    {
        public RecipeIngredientBase Ingredient { get; set; }
        public float Units { get; set; }

        public RecipeLineItem(RecipeIngredientBase ingredient, float units)
        {
            this.Ingredient = ingredient;
            this.Units = units;
        }
    }
}
