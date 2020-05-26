using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllerNamespace;
using System.Collections.Generic;
using DataModel;

namespace UnitTest
{
    [TestClass]
    public class UnitTestControllerClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("ingredients=apples,+flour,+sugar", 2);
            List<RecipeData> listRecipes2 = controller.GetRecipiesFromIngridients("ingredients=appless,+flouR,+sugar32", 2);

            Assert.AreEqual(listRecipes1,listRecipes2, "ingredients1: apples flour sugar \n ingredients: appless flouR sugar32");

        }
        [TestMethod]
        public void TestMethod2()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("apples, flour, sugar", 2);
            List<RecipeData> listRecipes2 = controller.GetRecipiesFromIngridients("appless, flouR, sugar32", 2);

            Assert.AreEqual(listRecipes1, listRecipes2, "ingredients1: apples, flour, sugar \n ingredients2: appless, flouR, sugar32");

        }
        [TestMethod]
        public void TestMethod3()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("cheese", 2);
            List<RecipeData> listRecipes2 = controller.GetRecipiesFromIngridients("cheese", 2);

            Assert.AreEqual(listRecipes1, listRecipes2, "ingredients1: cheese \n ingredients2: cheese");

        }
        [TestMethod]
        public void TestMethod4()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("bread, cheese", 2);
            List<RecipeData> listRecipes2 = controller.GetRecipiesFromIngridients("bread,cheese", 2);

            Assert.AreEqual(listRecipes1, listRecipes2, "ingredients1: bread, cheese \n ingredients2: bread,cheese");

        }
        [TestMethod]
        public void TestMethod5()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("bread, cheese", 2);
            List<RecipeData> listRecipes2 = controller.GetRecipiesFromIngridients("bread cheese", 2);

            Assert.AreEqual(listRecipes1, listRecipes2, "ingredients1: bread, cheese \n ingredients2: bread cheese");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Controller controller = new Controller();
            List<RecipeData> listRecipes1 = controller.GetRecipiesFromIngridients("bread, cheese", 2);
            List<RecipeData> listRecipes2 = controller.GetRecipiesFromIngridients("bread, cheesssse", 2);

            Assert.AreEqual(listRecipes1, listRecipes2, "ingredients1: bread, cheese \n ingredients2: bread, cheesssse");
        }
    }
}
