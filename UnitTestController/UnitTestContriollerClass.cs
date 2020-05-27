using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllerNamespace;
using System.Collections.Generic;
using DataModel;
using System;

namespace UnitTest
{
   // [TestClass]
    public abstract class UnitTestControllerClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("   AppLeS    ", 2);

            Assert.AreEqual(listRecipes1.Count,2);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("bread, cheese", 1);
            List<RecipeData> listRecipes2 = controller.GetRecipiesFromIngridients("bread, cheesssse", 1);

            Assert.AreEqual(listRecipes1[0].ID, listRecipes2[0].ID);
            
        }
        [TestMethod]
        public void TestMethod3()
        {
            Controller controller = new Controller();
            Dictionary<string, int> minCarbs = new Dictionary<string, int>();
            minCarbs["minCarbs"] = 10;
            minCarbs["maxCarbs"] = 100;
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromNutrients(minCarbs, 1);

            Assert.AreEqual(listRecipes1.Count>0,true);

        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void TestMethod4()
        {
            Controller controller = new Controller();
            Dictionary<string, int> minCarbs = new Dictionary<string, int>();
            minCarbs["minCarbs"] = 10;
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromNutrients(minCarbs, 1);
        }
        [TestMethod]
        public void TestMethod5()
        {

            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("bread, cheese", 2);
            List<RecipeData> listRecipes2 = controller.GetRecipiesFromIngridients("bread,cheese", 2);

            Assert.AreEqual(listRecipes1[0].ID, listRecipes2[0].ID);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("sugarrrr", 1);

            Assert.AreEqual(listRecipes1.Count, 0);
        }
    }
}
