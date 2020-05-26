/**
 * Clasa ParseIngredients reprezinta o implementare a interfetei IParse. Deoarece este gandita flexibilitatea
 * programului si eventuala extindere a functionalitatilor de parsare a query-urilorm de cautare, se foloseste 
 * aceasta implementare. Aceasta clasa primeste in constructor parametrii inputIngredients si numberRecipes
 * care vor fi parsati intr-un singur string potrivit functiilor de cautare al API-ului.
 * Autor: Georgiana Raschitor
 */
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

        // Metoda CreateQuery implementeaza unica functionalitate a clasei: de a parsa parametrii intr-un query.
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
