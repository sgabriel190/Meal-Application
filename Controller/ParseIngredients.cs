
namespace Controller
{
    class ParseIngredients : IParse
    {
        private string _input;

        public ParseIngredients(string input)
        {
            _input = input;
        }

        public string CreateQuery()
        {
            string query = "";
            string []words;
            int i;
            
            _input = _input.Replace(" ", "");
            words = _input.Split(',');
            for (i = 0; i < words.Length - 1; i++)
            {
                query += words[i] + ",+";
            }
            query += words[i];

            return query;
        }
    }
}
