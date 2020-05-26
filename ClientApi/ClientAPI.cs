using System;
using System.Net.Http;
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
        private static ClientAPI _instance = null;
        private const string _apiURL = "https://api.spoonacular.com";
        private string _apiKey = "apiKey=7b137a9d00974ba4b92d25f4d51d11";
        private HttpClient _httpClient = null;
        private PathBuilder _pathBuilder = null;

        private ClientAPI()
        {
            //Instantiere si setari client HTTP
            _httpClient = new HttpClient();
            _pathBuilder = new PathBuilder();
            _httpClient.BaseAddress = new System.Uri(_apiURL);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }
       
        public static ClientAPI GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ClientAPI();
            }
            return _instance;
        }
        public string ApiKey
        {
            set { _apiKey = "apiKey=" + value; }
        }
        public JArray SearchByIngredients(string ingredientQuery)
        {
            string path = _pathBuilder.BuildPathIngredients(_apiKey, ingredientQuery);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            return ReturnJsonArrayFromResponse(response);
        }
        public JArray SearchByNutrients(string nutrientsQuery)
        {
            string path = _pathBuilder.BuildPathNutrients(_apiKey, nutrientsQuery);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            return ReturnJsonArrayFromResponse(response);
        }
        public JObject GenerateMealPlan(string mealPlannerQuery)
        {
            string path = _pathBuilder.BuildPathGenerateMealPlan(_apiKey, mealPlannerQuery);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            return ReturnJsonObjectFromResponse(response);
        }
        public JObject GetById(int id)
        {
            string path = _pathBuilder.BuildPathInformationId(_apiKey, id);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            return ReturnJsonObjectFromResponse(response);
        }

        private JArray ReturnJsonArrayFromResponse(HttpResponseMessage response)
        {
            JArray json = null;
            if (response.IsSuccessStatusCode)
            {
                string dataObject = response.Content.ReadAsStringAsync().Result;
                json = JArray.Parse(dataObject);
                return json;
            }
            else
            {
                CheckErrorMessage(response);
            }
            return json;
        }
        private JObject ReturnJsonObjectFromResponse(HttpResponseMessage response)
        {
            JObject json = null;
            if (response.IsSuccessStatusCode)
            {
                string dataObject = response.Content.ReadAsStringAsync().Result;
                json = JObject.Parse(dataObject);
                return json;
            }
            else
            {
                CheckErrorMessage(response);
            }
            return json;
        }

        private void CheckErrorMessage(HttpResponseMessage response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new System.Exception("HTTP not found with status code: " + response.StatusCode + ": " + ((int)response.StatusCode).ToString());
            }
            if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                throw new System.Exception("HTTP forbidden with status code: " + response.StatusCode + ": " + ((int)response.StatusCode).ToString());
            }
            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                throw new System.Exception("HTTP bad request with status code: " + response.StatusCode + ": " + ((int)response.StatusCode).ToString());
            }
            if (response.StatusCode == System.Net.HttpStatusCode.GatewayTimeout)
            {
                throw new System.Exception("HTTP gateway timeout with status code: " + response.StatusCode + ": " + ((int)response.StatusCode).ToString());
            }
            if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new System.Exception("HTTP internal server error with status code: " + response.StatusCode + ": " + ((int)response.StatusCode).ToString());
            }
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new System.Exception("HTTP unauthorized error with status code: " + response.StatusCode + ": " + ((int)response.StatusCode).ToString()
                    + Environment.NewLine + "Please create an api key!"
                    + Environment.NewLine + " Create an account for free and get your key: https://spoonacular.com/food-api");
            }
            throw new System.Exception("HTTP unknown error with status code: " + response.StatusCode + ": " + ((int)response.StatusCode).ToString()
                    + Environment.NewLine + "Please change the api key!"
                    + Environment.NewLine + " Create an account for free here: https://spoonacular.com/food-api");
        }
    }
}
