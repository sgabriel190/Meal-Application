using System.Net.Http;
using System.Net.Http.Headers;
using System.Json;
using System.Collections.Generic;
using System.IO;

namespace ClientApi
{
    /**
     *  Clasa ClientAPI contine un client HTTP care permite aplicatiei sa comunice cu serverul API 
     * folosidu-i functiile puse la dispozitie pentru a dispune de datele necesare.
     */
    public class ClientAPI
    {
        private ClientAPI instance = null;
        private const string apiURL = "https://api.spoonacular.com";
        private const string apiKey = "apiKey=7b137a9d00974ba4b92d25f4d51d11c6";
        private HttpClient httpClient = null;
        private PathBuilder pathBuilder = null;

        private ClientAPI()
        {
            //Instantiere si setari client HTTP
            httpClient = new HttpClient();
            pathBuilder = new PathBuilder();
            httpClient.BaseAddress = new System.Uri(apiURL);
            httpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }

        public ClientAPI getInstance()
        {
            if(instance == null)
            {
                instance = new ClientAPI();
            }
            return instance;
        }
        public JsonObject searchByIngredients(string ingredientQuery, int numberRecipes)
        {
            string path = pathBuilder.buildPathIngredients(apiKey, ingredientQuery, numberRecipes);
            HttpResponseMessage response = httpClient.GetAsync(path).Result;
            if(response.IsSuccessStatusCode)
            {

            }
            throw new System.Exception("nu este implementat");
        }
        public JsonObject searchByNutrients(string nutrientsQuery)
        {
            string path = pathBuilder.buildPathNutrients(apiKey, nutrientsQuery);
            HttpResponseMessage response = httpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {

            }
            throw new System.Exception("nu este implementat");
        }
        public JsonObject getById(int id)
        {
            string path = pathBuilder.buildPathInformationId(apiKey, id);
            HttpResponseMessage response = httpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {

            }
            throw new System.Exception("nu este implementat");
        }
    }
}
