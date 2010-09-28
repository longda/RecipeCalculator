using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCalculator.Model
{
    public class OrganicGarlic : RecipeIngredientBase
    {
        public override string Name { get { return "Clove of Organic Garlic"; } }
        public override bool IsOrganic { get { return true; } }
        public override bool IsProduce { get { return true; } }
        public override int Cost { get { return 67; } }
    }
}
