using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using RecipeCalculator.Model;

namespace RecipeCalculator.Model.TestModel
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
        public void TestOrganicGarlic()
        {
            int TARGET_COST = 67;
            OrganicGarlic foo = new OrganicGarlic();
            Assert.IsTrue(foo.IsOrganic, "IsOrganic should be true.");
            Assert.IsTrue(foo.IsProduce, "IsProduce should be true.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestLemon()
        {
            int TARGET_COST = 203;
            Lemon foo = new Lemon();
            Assert.IsFalse(foo.IsOrganic, "IsOrganic should be false.");
            Assert.IsTrue(foo.IsProduce, "IsProduce should be true.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestCorn()
        {
            int TARGET_COST = 87;
            Corn foo = new Corn();
            Assert.IsFalse(foo.IsOrganic, "IsOrganic should be false.");
            Assert.IsTrue(foo.IsProduce, "IsProduce should be true.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestChickenBreast()
        {
            int TARGET_COST = 219;
            ChickenBreast foo = new ChickenBreast();
            Assert.IsFalse(foo.IsOrganic, "IsOrganic should be false.");
            Assert.IsFalse(foo.IsProduce, "IsProduce should be false.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestBacon()
        {
            int TARGET_COST = 24;
            Bacon foo = new Bacon();
            Assert.IsFalse(foo.IsOrganic, "IsOrganic should be false.");
            Assert.IsFalse(foo.IsProduce, "IsProduce should be false.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestPasta()
        {
            int TARGET_COST = 31;
            Pasta foo = new Pasta();
            Assert.IsFalse(foo.IsOrganic, "IsOrganic should be false.");
            Assert.IsFalse(foo.IsProduce, "IsProduce should be false.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestOrganicOliveOil()
        {
            int TARGET_COST = 192;
            OrganicOliveOil foo = new OrganicOliveOil();
            Assert.IsTrue(foo.IsOrganic, "IsOrganic should be true.");
            Assert.IsFalse(foo.IsProduce, "IsProduce should be false.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestVinegar()
        {
            int TARGET_COST = 126;
            Vinegar foo = new Vinegar();
            Assert.IsFalse(foo.IsOrganic, "IsOrganic should be false.");
            Assert.IsFalse(foo.IsProduce, "IsProduce should be false.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestSalt()
        {
            int TARGET_COST = 16;
            Salt foo = new Salt();
            Assert.IsFalse(foo.IsOrganic, "IsOrganic should be false.");
            Assert.IsFalse(foo.IsProduce, "IsProduce should be false.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestPepper()
        {
            int TARGET_COST = 17;
            Pepper foo = new Pepper();
            Assert.IsFalse(foo.IsOrganic, "IsOrganic should be false.");
            Assert.IsFalse(foo.IsProduce, "IsProduce should be false.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }

        [TestMethod]
        public void TestGenericRecipeIngredient()
        {
            int TARGET_COST = 199;
            GenericRecipeIngredient foo = new GenericRecipeIngredient("Package of Organice Blueberries", true, true, 199);
            Assert.IsTrue(foo.IsOrganic, "IsOrganic should be true.");
            Assert.IsTrue(foo.IsProduce, "IsProduce should be true.");
            Assert.AreEqual(TARGET_COST, foo.Cost, string.Format("Cost is incorrect.", TARGET_COST));
        }
    }
}
