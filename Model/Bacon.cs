using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCalculator.Model
{
    public class Bacon : RecipeIngredientBase
    {
        public override string Name { get { return "Slice of Bacon"; } }
        public override bool IsOrganic { get { return false; } }
        public override bool IsProduce { get { return false; } }
        public override int Cost { get { return 24; } }
    }
}
