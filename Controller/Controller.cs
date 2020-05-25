using ClientApi;
using DataModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using FileParser;
using System.Globalization;
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
        private ClientAPI clientAPI = null;
        private IParse queryParser = null;
        private IFilter filter = null;

        public Controller()
        {
            clientAPI = ClientAPI.GetInstance();
        }

        public List<RecipeData> GetRecipiesFromIngridients(string inputIngredients, int numberOfRecipes)
        {
            List<RecipeData> listOfRecipies = new List<RecipeData>();

            queryParser = new ParseIngredients(inputIngredients, numberOfRecipes);
            string query = queryParser.CreateQuery();
            JArray searchResult = clientAPI.SearchByIngredients(query);

            filter = new FilterJSON(searchResult);
            listOfRecipies = filter.FilterMultipleData();

            return listOfRecipies;
        }

        public List<RecipeData> GetRecipesMealPlan(int targetCalories, string diet, string exclude)
        {
            List<RecipeData> listOfRecipies = new List<RecipeData>();
            queryParser = new ParseMealGenerate(targetCalories, diet, exclude);
            string query = queryParser.CreateQuery();
            JObject searchResult = clientAPI.GenerateMealPlan(query);
            JArray listMeals = (JArray)searchResult.GetValue("meals");

            foreach (JObject JSONobj in listMeals)
            {
                JObject resultById = clientAPI.GetById(Int32.Parse(JSONobj.GetValue("id").ToString()));
                filter = new FilterJSON(resultById);
                RecipeData meal = filter.FilterData();
                meal = filter.CompleteData(meal);
                listOfRecipies.Add(meal);
            }

            return listOfRecipies;
        }

        public List<RecipeData> GetRecipiesFromNutrients(Dictionary<string, int> inputedNutrients, int numberOfRecipes)
        {
            List<RecipeData> listOfRecipies = new List<RecipeData>();

            queryParser = new ParseNutrients(inputedNutrients, numberOfRecipes);
            string query = queryParser.CreateQuery();
            JArray searchResult = clientAPI.SearchByNutrients(query);

            filter = new FilterJSON(searchResult);
            listOfRecipies = filter.FilterMultipleData();


            return listOfRecipies;
        }

        public RecipeData GetRecipeById(RecipeData dataModel)
        {
            JObject searchResult = clientAPI.GetById(dataModel.ID);
            filter = new FilterJSON(searchResult);
            dataModel = filter.CompleteData(dataModel);
            return dataModel;
        }

    }
}
