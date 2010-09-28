using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using RecipeCalculator.Model;
using RecipeCalculator.Utility;

namespace RecipeCalculator.Utility.TestUtility
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCalculateTax()
        {
            List<RecipeLineItem> recipe = new List<RecipeLineItem>();
            recipe.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe.Add(new RecipeLineItem(new Lemon(), 1.00f));
            recipe.Add(new RecipeLineItem(new OrganicOliveOil(), 0.75f));
            recipe.Add(new RecipeLineItem(new Salt(), 0.75f));
            recipe.Add(new RecipeLineItem(new Pepper(), 0.50f));

            Assert.AreEqual(28, RecipeHelper.CalculateTax(recipe.ToArray()), "Tax calculation is incorrect.");
        }

        [TestMethod]
        public void TestCalculateDiscount()
        {
            List<RecipeLineItem> recipe = new List<RecipeLineItem>();
            recipe.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe.Add(new RecipeLineItem(new Lemon(), 1.00f));
            recipe.Add(new RecipeLineItem(new OrganicOliveOil(), 0.75f));
            recipe.Add(new RecipeLineItem(new Salt(), 0.75f));
            recipe.Add(new RecipeLineItem(new Pepper(), 0.50f));

            Assert.AreEqual(11, RecipeHelper.CalculateDiscount(recipe.ToArray()), "Discount calculation is incorrect.");
        }

        [TestMethod]
        public void TestCalculateTotal()
        {
            List<RecipeLineItem> recipe = new List<RecipeLineItem>();
            recipe.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe.Add(new RecipeLineItem(new Lemon(), 1.00f));
            recipe.Add(new RecipeLineItem(new OrganicOliveOil(), 0.75f));
            recipe.Add(new RecipeLineItem(new Salt(), 0.75f));
            recipe.Add(new RecipeLineItem(new Pepper(), 0.50f));

            Assert.AreEqual(452, RecipeHelper.CalculateTotal(recipe.ToArray()), "Total calculation is incorrect.");
        }

        [TestMethod]
        public void TestRecipe1()
        {
            List<RecipeLineItem> recipe = new List<RecipeLineItem>();
            recipe.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe.Add(new RecipeLineItem(new Lemon(), 1.00f));
            recipe.Add(new RecipeLineItem(new OrganicOliveOil(), 0.75f));
            recipe.Add(new RecipeLineItem(new Salt(), 0.75f));
            recipe.Add(new RecipeLineItem(new Pepper(), 0.50f));

            Assert.AreEqual(28, RecipeHelper.CalculateTax(recipe.ToArray()), "Tax calculation is incorrect.");
            Assert.AreEqual(11, RecipeHelper.CalculateDiscount(recipe.ToArray()), "Discount calculation is incorrect.");
            Assert.AreEqual(452, RecipeHelper.CalculateTotal(recipe.ToArray()), "Total calculation is incorrect.");
        }

        [TestMethod]
        public void TestRecipe2()
        {
            List<RecipeLineItem> recipe = new List<RecipeLineItem>();
            recipe.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe.Add(new RecipeLineItem(new ChickenBreast(), 4.00f));
            recipe.Add(new RecipeLineItem(new OrganicOliveOil(), 0.50f));
            recipe.Add(new RecipeLineItem(new Vinegar(), 0.50f));

            Assert.AreEqual(98, RecipeHelper.CalculateTax(recipe.ToArray()), "Tax calculation is incorrect.");
            Assert.AreEqual(8, RecipeHelper.CalculateDiscount(recipe.ToArray()), "Discount calculation is incorrect.");
            Assert.AreEqual(1192, RecipeHelper.CalculateTotal(recipe.ToArray()), "Total calculation is incorrect.");
        }

        [TestMethod]
        public void TestRecipe3()
        {
            List<RecipeLineItem> recipe = new List<RecipeLineItem>();
            recipe.Add(new RecipeLineItem(new OrganicGarlic(), 1.00f));
            recipe.Add(new RecipeLineItem(new Corn(), 4.00f));
            recipe.Add(new RecipeLineItem(new Bacon(), 4.00f));
            recipe.Add(new RecipeLineItem(new Pasta(), 8.00f));
            recipe.Add(new RecipeLineItem(new OrganicOliveOil(), 0.3333f)); // 1.00f / 3.00f));
            recipe.Add(new RecipeLineItem(new Salt(), 1.25f));
            recipe.Add(new RecipeLineItem(new Pepper(), 0.75f));

            Assert.AreEqual(63, RecipeHelper.CalculateTax(recipe.ToArray()), "Tax calculation is incorrect.");
            Assert.AreEqual(7, RecipeHelper.CalculateDiscount(recipe.ToArray()), "Discount calculation is incorrect.");
            Assert.AreEqual(912, RecipeHelper.CalculateTotal(recipe.ToArray()), "Total calculation is incorrect.");
        }

        [TestMethod]
        public void TestCalculateIngredientDiscountAmount()
        {
            Console.WriteLine((int)Math.Round(1.0f, MidpointRounding.AwayFromZero));
            Console.WriteLine((int)Math.Round(1.2f, MidpointRounding.AwayFromZero));
            Console.WriteLine((int)Math.Round(1.5f, MidpointRounding.AwayFromZero));
            Console.WriteLine((int)Math.Round(1.8f, MidpointRounding.AwayFromZero));

            Assert.AreEqual(3, RecipeHelper.CalculateIngredientDiscountAmount(new OrganicGarlic()), "Ingredient discount amount calculation is incorrect.");
            Assert.AreEqual(0, RecipeHelper.CalculateIngredientDiscountAmount(new Lemon()), "Ingredient discount amount calculation is incorrect.");
            Assert.AreEqual(10, RecipeHelper.CalculateIngredientDiscountAmount(new OrganicOliveOil()), "Ingredient discount amount calculation is incorrect.");
            Assert.AreEqual(0, RecipeHelper.CalculateIngredientDiscountAmount(new Salt()), "Ingredient discount amount calculation is incorrect.");
            Assert.AreEqual(0, RecipeHelper.CalculateIngredientDiscountAmount(new Pepper()), "Ingredient discount amount calculation is incorrect.");
        }

        [TestMethod]
        public void TestCalculateIngredientDiscountedPrice()
        {
        }

        [TestMethod]
        public void TestCalculateIngredientExtendedPrice()
        {
            Console.WriteLine(192*0.95f*0.75f);
            Assert.AreEqual(64, (int)Math.Round(RecipeHelper.CalculateIngredientExtendedPrice(64, 1.00f), MidpointRounding.AwayFromZero));
            Assert.AreEqual(203, (int)Math.Round(RecipeHelper.CalculateIngredientExtendedPrice(203, 1.00f), MidpointRounding.AwayFromZero));
            Assert.AreEqual(137, (int)Math.Round(RecipeHelper.CalculateIngredientExtendedPrice(182, 0.75f), MidpointRounding.AwayFromZero));
            Assert.AreEqual(12, (int)Math.Round(RecipeHelper.CalculateIngredientExtendedPrice(16, 0.75f), MidpointRounding.AwayFromZero));
            Assert.AreEqual(9, (int)Math.Round(RecipeHelper.CalculateIngredientExtendedPrice(17, 0.50f), MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestCalculateIngredientTax()
        {
            Assert.AreEqual(0, RecipeHelper.CalculateIngredientTax(new OrganicGarlic(), 64), "Tax calculation is incorrect.");
            Assert.AreEqual(0, RecipeHelper.CalculateIngredientTax(new Lemon(), 203), "Tax calculation is incorrect.");
            Assert.AreEqual(14, RecipeHelper.CalculateIngredientTax(new OrganicOliveOil(), 137), "Tax calculation is incorrect.");
            Assert.AreEqual(7, RecipeHelper.CalculateIngredientTax(new Salt(), 12), "Tax calculation is incorrect.");
            Assert.AreEqual(7, RecipeHelper.CalculateIngredientTax(new Pepper(), 9), "Tax calculation is incorrect.");
        }
    }
}
