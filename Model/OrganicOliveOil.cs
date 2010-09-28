using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCalculator.Model
{
    public class OrganicOliveOil : RecipeIngredientBase
    {
        public override string Name { get { return "Cup of Organic Olive Oil"; } }
        public override bool IsOrganic { get { return true; } }
        public override bool IsProduce { get { return false; } }
        public override int Cost { get { return 192; } }
    }
}
