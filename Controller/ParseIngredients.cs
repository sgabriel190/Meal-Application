
namespace ControllerNamespace
{
    class ParseIngredients : IParse
    {
        private string _input;
        private int _number;

        public ParseIngredients(string inputIngredients, int numberRecipes)
        {
            _input = inputIngredients;
            _number = numberRecipes;
        }

        public string CreateQuery()
        {
            string query = "ingredients=";
            string []words;
            int i;
            
            _input = _input.Replace(" ", "");
            words = _input.Split(',');

            for (i = 0; i < words.Length - 1; i++)
            {
                query += words[i] + ",+";
            }
            query += words[i];

            query += $"&number={_number}";
            return query;
        }
    }
}
