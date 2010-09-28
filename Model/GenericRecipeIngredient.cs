using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCalculator.Model
{
    public class GenericRecipeIngredient : RecipeIngredientBase
    {
        private string name;
        public override string Name { get { return name; } }

        private bool isOrganic;
        public override bool IsOrganic { get { return isOrganic; } }

        private bool isProduce;
        public override bool IsProduce { get { return isProduce; } }

        private int cost;
        public override int Cost { get { return cost; } }

        public GenericRecipeIngredient(string name, bool isOrganic, bool isProduce, int cost)
            : base()
        {
            this.name = name;
            this.isOrganic = isOrganic;
            this.isProduce = isProduce;
            this.cost = cost;
        }
    }
}
