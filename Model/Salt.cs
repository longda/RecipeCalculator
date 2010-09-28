using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCalculator.Model
{
    public class Salt : RecipeIngredientBase
    {
        public override string Name { get { return "Teaspoon of Salt"; } }
        public override bool IsOrganic { get { return false; } }
        public override bool IsProduce { get { return false; } }
        public override int Cost { get { return 16; } }
    }
}
