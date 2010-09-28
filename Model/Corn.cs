using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCalculator.Model
{
    public class Corn : RecipeIngredientBase
    {
        public override string Name { get { return "Cup of Corn"; } }
        public override bool IsOrganic { get { return false; } }
        public override bool IsProduce { get { return true; } }
        public override int Cost { get { return 87; } }
    }
}
