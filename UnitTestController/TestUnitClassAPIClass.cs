using System;
using ClientApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace UnitTestController
{
    [TestClass]
    public class TestUnitClassAPIClass
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            ClientAPI clientAPI = ClientAPI.GetInstance();
            JArray arrayJSON1 = clientAPI.SearchByIngredients("ingredients=apples,+flour,+sugar&number=2");
            JArray arrayJSON2 = clientAPI.SearchByIngredients("ingredients=apples,+FLOUR,+sugar&number=2");
            Assert.AreEqual(arrayJSON1.ToString(), arrayJSON2.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            ClientAPI clientAPI = ClientAPI.GetInstance();
            JArray arrayJSON1 = clientAPI.SearchByIngredients("ingredients=apples&number=1");
            JArray arrayJSON2 = clientAPI.SearchByIngredients("ingredients=apples&number=1");

            Assert.AreEqual(arrayJSON1.ToString(), arrayJSON2.ToString());

        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void TestMethod3()
        {  
            ClientAPI clientAPI = ClientAPI.GetInstance();
            clientAPI.ApiKey = "invalid api";
            JArray arrayJSON1 = clientAPI.SearchByIngredients("ingredients=apples,+flour,+sugar&number=2");

        }
    }
}
