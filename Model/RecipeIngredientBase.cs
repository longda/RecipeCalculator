using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCalculator.Model
{
    public abstract class RecipeIngredientBase
    {
        public abstract string Name { get; }
        public abstract bool IsOrganic { get; }
        public abstract bool IsProduce { get; }

        /// <summary>
        /// Cost in monetary units... for now we can assume this would be cents (until a localization project).
        /// This will aide in calculations that tend to get tricky regarding rounding such as extended cost and tax.
        /// Ex: 97 for cost is the equivalent to 97 cents or 0.97.
        /// </summary>
        public abstract int Cost { get; }
        //public abstract int Discount { get; } //{ get { return 100; } }
        //public float DiscountRate { get { return Discount / 100; } }

        public RecipeIngredientBase() { }

        public override string ToString() { return string.IsNullOrEmpty(Name) ? base.ToString() : Name; }
    }
}
