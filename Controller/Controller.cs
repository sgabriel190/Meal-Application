using ClientApi;
using DataModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using FileParser;
using System;

namespace ControllerNamespace
{
    /**
     * Clasa controller detine acces direct care toate functionalitatile aplicatiei,
     * prin urmare este singura clasa care comunica cu interfata si dirijeaza functionalitatile
     * claselor proiectate pentru backend.
     */
    public class Controller
    {
        private ClientAPI _clientAPI = null;
        private IParse _queryParser = null;
        private IFilter _filter = null;

        public Controller()
        {
            _clientAPI = ClientAPI.GetInstance();
        }

        public void SetApiKey(string apiKey)
        {
            _clientAPI.ApiKey = apiKey;
        }
        public List<RecipeData> GetRecipiesFromIngridients(string inputIngredients, int numberOfRecipes)
        {
            List<RecipeData> listOfRecipies = new List<RecipeData>();

            _queryParser = new ParseIngredients(inputIngredients, numberOfRecipes);
            string query = _queryParser.CreateQuery();
            JArray searchResult = _clientAPI.SearchByIngredients(query);

            _filter = new FilterJSON(searchResult);
            listOfRecipies = _filter.FilterMultipleData();

            return listOfRecipies;
        }

        public List<RecipeData> GetRecipesMealPlan(int targetCalories, string diet, string exclude)
        {
            List<RecipeData> listOfRecipies = new List<RecipeData>();
            _queryParser = new ParseMealGenerate(targetCalories, diet, exclude);
            string query = _queryParser.CreateQuery();
            JObject searchResult = _clientAPI.GenerateMealPlan(query);
            JArray listMeals = (JArray)searchResult.GetValue("meals");

            foreach (JObject JSONobj in listMeals)
            {
                JObject resultById = _clientAPI.GetById(Int32.Parse(JSONobj.GetValue("id").ToString()));
                _filter = new FilterJSON(resultById);
                RecipeData meal = _filter.FilterData();
                meal = _filter.CompleteData(meal);
                listOfRecipies.Add(meal);
            }

            return listOfRecipies;
        }

        public List<RecipeData> GetRecipiesFromNutrients(Dictionary<string, int> inputedNutrients, int numberOfRecipes)
        {
            List<RecipeData> listOfRecipies = new List<RecipeData>();

            _queryParser = new ParseNutrients(inputedNutrients, numberOfRecipes);
            string query = _queryParser.CreateQuery();
            JArray searchResult = _clientAPI.SearchByNutrients(query);

            _filter = new FilterJSON(searchResult);
            listOfRecipies = _filter.FilterMultipleData();


            return listOfRecipies;
        }

        public RecipeData GetCompleteRecipe(RecipeData dataModel)
        {
            JObject searchResult = _clientAPI.GetById(dataModel.ID);
            _filter = new FilterJSON(searchResult);
            dataModel = _filter.CompleteData(dataModel);
            return dataModel;
        }

    }
}
