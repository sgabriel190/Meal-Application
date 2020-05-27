using ClientApi;
using DataModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using FileParser;
using System;
/**
* Clasa controller detine acces direct care toate functionalitatile aplicatiei,
* prin urmare este singura clasa care comunica cu interfata si dirijeaza functionalitatile
* claselor proiectate.
* Autor: Georgiana Raschitor
*/

namespace ControllerNamespace
{
    
    public class Controller
    {
        private ClientAPI _clientAPI = null;
        private IParse _queryParser = null;
        private IFilter _filter = null;

        public Controller()
        {
            _clientAPI = ClientAPI.GetInstance();
        }

        /// <summary>
        /// Metoda setter pentru a seta un apiKey introdus de utilizator
        /// </summary>
        /// <param name="apiKey">Reprezinta inputul de tip string introdus de utilizator pe interfata.</param>
        public void SetApiKey(string apiKey)
        {
            _clientAPI.ApiKey = apiKey;
        }

        /// <summary>
        /// Se utilizeaza clasele ClientAPI, ParseIngredients si FilterJSON pentru a obtine o lista de retete potrivit modelului de date RecipeData.
        /// </summary>
        /// <param name="inputIngredients">defineste inputul de ingrediente definit de catre utilizator.</param>
        /// <param name="numberOfRecipes">valoarea numerica oferita de utilizator ce reprezinta numarul de retete cautate de api.</param>
        /// <returns>O lista de modele de date, pregatite pentru preview, rezultate in urma cautarii</returns>
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

        /// <summary>
        /// Se utilizeaza clasele ClientAPI, ParseIngredients si FilterJSON pentru a obtine o lista de retete potrivit modelului de date RecipeData.
        /// </summary>
        /// <param name="targetCalories">Reprezinta valoarea numerica introdusa de utilizator pentru numarul de calorii in care sa se incadreze planul.</param>
        /// <param name="diet">Defineste dieta aleasa de utilizator; aceasta poate sa lipseasca.</param>
        /// <param name="exclude">Un input de tip string care mentioneaza ce sa fie exclus din plan.</param>
        /// <returns>O lista de modele de date, pregatite pentru preview, rezultate in urma cautarii</returns>
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

        /// <summary>
        /// Se utilizeaza clasele ClientAPI, ParseIngredients si FilterJSON pentru a obtine o lista de retete potrivit modelului de date RecipeData.
        /// </summary>
        /// <param name="inputedNutrients">Este reprezentat ca un dictionar ce contine valorile minime si maxime 
        /// pentru categoriile alese dintre nutrientii pusi la dispozitie pe interfata.</param>
        /// <param name="numberOfRecipes">Reprezinta o valoare introdusa de utilizator 
        /// care sugereaza numarul de retete care sa fie inclus in cautare.</param>
        /// <returns>O lista de modele de date, pregatite pentru preview, rezultate in urma cautarii.</returns>
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

        /// <summary>
        /// Se utilizeaza clasele ClientAPI, ParseIngredients si FilterJSON pentru a obtine o reteta completa conform modelului de date RecipeData.
        /// </summary>
        /// <param name="dataModel">Reprezinta un model de data pentru retete care nu este complet si urmeaza sa fie completat</param>
        /// <returns>Un model de date pentru reteke folosite la afisarea completa</returns>
        public RecipeData GetCompleteRecipe(RecipeData dataModel)
        {
            JObject searchResult = _clientAPI.GetById(dataModel.ID);
            _filter = new FilterJSON(searchResult);
            dataModel = _filter.CompleteData(dataModel);
            return dataModel;
        }

    }
}
