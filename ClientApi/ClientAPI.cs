using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
/***
 * Clasa ClientAPI implementeaza un client HTTP care sa se ocupe de comunicatia cu serverul HTTP oferit de API.
 * Tot in aceasta clasa se incearca indentificare erorilor aparute prin urmarea accesarii serverului HTTP.
 * Autor: Strilciuc Gabriel
 ***/

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
        private string _apiKey = "apiKey=a3a2299445e34aef82762e4fa925d413";

        private HttpClient _httpClient = null;
        private PathBuilder _pathBuilder = null;

        // Constructor privat pentru realizarea sablonului de singleton
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
       
        // Metoda publica pentru a accesa unica instanta de clientAPI din aplicatie
        public static ClientAPI GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ClientAPI();
            }
            return _instance;
        }
        // Metoda setter pentru atributul apiKey
        public string ApiKey
        {
            set { _apiKey = "apiKey=" + value; }
        }

        /**
         * Metoda SearchByIngredients primeste ca parametru un query URI si foloseste clientul HTTP 
         * definit local in clasa pentru a apela functiile API-ului prin protocolul HTTP.
         *** Query-ul contine parametrii necesari functiei de cautare bazata pe ingrediente.
         * Aceasta clasa returneaza un JArray, continut de raspunsul HTTP primit de la API.
         */
        public JArray SearchByIngredients(string ingredientQuery)
        {
            string path = _pathBuilder.BuildPathIngredients(_apiKey, ingredientQuery);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            return ReturnJsonArrayFromResponse(response);
        }

        /**
         * Metoda SearchByNutrients primeste ca parametru un query URI si foloseste clientul HTTP 
         * definit local in clasa pentru a apela functiile API-ului prin protocolul HTTP.
         *** Query-ul contine parametrii necesari functiei de cautare bazata pe nutrienti.
         * Aceasta clasa returneaza un JArray, continut de raspunsul HTTP primit de la API.
         */
        public JArray SearchByNutrients(string nutrientsQuery)
        {
            string path = _pathBuilder.BuildPathNutrients(_apiKey, nutrientsQuery);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            return ReturnJsonArrayFromResponse(response);
        }

        /**
         * Metoda GenerateMealPlan primeste ca parametru un query URI si foloseste clientul HTTP 
         * definit local in clasa pentru a apela functiile API-ului prin protocolul HTTP.
         *** Query-ul contine parametrii necesari functiei de generare a unui plan alimentar bazat pe un numar de parametrii.
         * Aceasta clasa returneaza un JObject, continut de raspunsul HTTP primit de la API.
         */
        public JObject GenerateMealPlan(string mealPlannerQuery)
        {
            string path = _pathBuilder.BuildPathGenerateMealPlan(_apiKey, mealPlannerQuery);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            return ReturnJsonObjectFromResponse(response);
        }

        /**
         * Metoda GetById primeste ca parametru un query URI si foloseste clientul HTTP 
         * definit local in clasa pentru a apela functiile API-ului prin protocolul HTTP.
         *** Query-ul contine parametrii necesari functiei de returnare a unei retete complete, bazat pe id.
         * Aceasta clasa returneaza un JObject, continut de raspunsul HTTP primit de la API.
         */
        public JObject GetById(int id)
        {
            string path = _pathBuilder.BuildPathInformationId(_apiKey, id);
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            return ReturnJsonObjectFromResponse(response);
        }

        /**
         * Metoda ReturnJsonArrayFromResponse primeste ca parametru raspunsul oferit de catre API aplicatiei
         * si pe baza acesuia, daca codul HTTP este unul de succes, se extrage din continut un array JSON.
         * Acest array este trimis ulterior aplicatiei pentru a pregatii datele datele necesare.
         */
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

        /**
         * Metoda ReturnJsonObjectFromResponse primeste ca parametru raspunsul oferit de catre API aplicatiei
         * si pe baza acesuia, daca codul HTTP este unul de succes, se extrage din continut un obiect JSON.
         * Acest obiect este trimis ulterior aplicatiei pentru a pregatii datele datele necesare.
         */
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

        /**
         * Metoda CheckErrorMessage este o functie de tip helper. Aceasta incearca sa decida, in cazul in care raspunsul 
         * HTTP nu are un cod de succes 2xx, in care dintre situatiile de eroare se afla si trimite o exceptie catre interfata.
         */
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
