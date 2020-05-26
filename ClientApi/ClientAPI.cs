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
        private string _apiKey = "apiKey=7b137a9d00974ba4b92d25f4d51d11c6";
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
        public JArray SearchByNutrients(string nutrientsQuery)
        {
            string path = _pathBuilder.BuildPathNutrients(_apiKey, nutrientsQuery);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
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
        public JObject GenerateMealPlan(string mealPlannerQuery)
        {
            string path = _pathBuilder.BuildPathGenerateMealPlan(_apiKey, mealPlannerQuery);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
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
        public JObject GetById(int id)
        {
            string path = _pathBuilder.BuildPathInformationId(_apiKey, id);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
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
