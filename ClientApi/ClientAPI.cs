﻿using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace ClientApi
{
    /**
     *  Clasa ClientAPI contine un client HTTP care permite aplicatiei sa comunice cu serverul API 
     * folosidu-i functiile puse la dispozitie pentru a dispune de datele necesare.
     */
    public class ClientAPI
    {
        private static ClientAPI instance = null;
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
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }

        public static ClientAPI GetInstance()
        {
            if(instance == null)
            {
                instance = new ClientAPI();
            }
            return instance;
        }
        public JArray SearchByIngredients(string ingredientQuery, int numberRecipes)
        {
            string path = pathBuilder.BuildPathIngredients(apiKey, ingredientQuery, numberRecipes);
            HttpResponseMessage response = httpClient.GetAsync(path).Result;
            if(response.IsSuccessStatusCode)
            {
                string dataObject = response.Content.ReadAsStringAsync().Result;
                JArray json = JArray.Parse(dataObject);
                return json;
            }
            else
            {
                throw new System.Exception("HTTP error");
            }
        }
        public JArray SearchByNutrients(string nutrientsQuery, int numberRecipes)
        {
            string path = pathBuilder.BuildPathNutrients(apiKey, nutrientsQuery, numberRecipes);
            HttpResponseMessage response = httpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string dataObject = response.Content.ReadAsStringAsync().Result;
                JArray json = JArray.Parse(dataObject);
                return json;
            }
            else
            {
                throw new System.Exception("HTTP error");
            }
        }
        public JObject GetById(int id)
        {
            string path = pathBuilder.BuildPathInformationId(apiKey, id);
            HttpResponseMessage response = httpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string dataObject = response.Content.ReadAsStringAsync().Result;
                JObject json = JObject.Parse(dataObject);
                return json;
            }
            else
            {
                throw new System.Exception("HTTP error");
            }
        }
    }
}
