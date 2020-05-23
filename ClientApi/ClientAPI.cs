using System.Net.Http;
using System.Net.Http.Headers;

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
        //viitor parser pentru request string

        private ClientAPI()
        {
            //Instantiere si setari client HTTP
            httpClient = new HttpClient();
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
    }
}
