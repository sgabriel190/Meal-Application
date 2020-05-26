using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientApi;
using Newtonsoft.Json.Linq;

namespace UnitTestController
{
    [TestClass]
    class UnitTestClientAPI
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClientAPI clientAPI = ClientAPI.GetInstance();
            JArray arrayJSON1 = clientAPI.SearchByIngredients("ingredients=apples,+flour,+sugar&number=2");
            JArray arrayJSON2 = clientAPI.SearchByIngredients("ingredients=apples,+floUur,+sugar&number=2");

            Assert.AreEqual(arrayJSON1, arrayJSON2);

        }

        [TestMethod]
        public void TestMethod2()
        {
            ClientAPI clientAPI = ClientAPI.GetInstance();
            JArray arrayJSON1 = clientAPI.SearchByIngredients("ingredients=apples&number=2");
            JArray arrayJSON2 = clientAPI.SearchByIngredients("ingredients=apples&number=2");

            Assert.AreEqual(arrayJSON1, arrayJSON2);

        }

        [TestMethod]
        public void TestMethod3()
        {
            ClientAPI clientAPI = ClientAPI.GetInstance();
            JArray arrayJSON1 = clientAPI.SearchByIngredients("ingredients=apples,struguri&number=2");
            JArray arrayJSON2 = clientAPI.SearchByIngredients("ingredients=apples&number=2");

            Assert.AreEqual(arrayJSON1, arrayJSON2);

        }
    }
}
