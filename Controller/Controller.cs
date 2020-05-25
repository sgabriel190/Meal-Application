using ClientApi;
using DataModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using FileParser;

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
        private FilterJSON filter = null;

        public Controller()
        {
            clientAPI = ClientAPI.GetInstance();
            filter = new FilterJSON();
        }

        public List<RecipeData> GetRecipiesFromIngridients(string inputIngredients, int numberOfRecipes)
        {
            List<RecipeData> listOfRecipies = new List<RecipeData>();

            queryParser = new ParseIngredients(inputIngredients, numberOfRecipes);
            string query = queryParser.CreateQuery();
            JArray searchResult = clientAPI.SearchByIngredients(query);

            listOfRecipies = filter.FilterMultipleData(searchResult);

            return listOfRecipies;
        }

        public List<RecipeData> GetRecipiesFromNutrients(Dictionary<string, int> inputedNutrients, int numberOfRecipes)
        {
            List<RecipeData> listOfRecipies = new List<RecipeData>();

            queryParser = new ParseNutrients(inputedNutrients, numberOfRecipes);
            string query = queryParser.CreateQuery();
            JArray searchResult = clientAPI.SearchByNutrients(query);

            listOfRecipies = filter.FilterMultipleData(searchResult);


            return listOfRecipies;
        }

    }
}
