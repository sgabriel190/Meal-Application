namespace ClientApi
{
    public class ClientAPI
    {
        private ClientAPI instance = null;
        private const string apiURL = "https://api.spoonacular.com";
        private const string apiKey = "apiKey=7b137a9d00974ba4b92d25f4d51d11c6";
        private ClientAPI()
        {

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
