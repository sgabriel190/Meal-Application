using System.Collections.Generic;
using System.Linq;
/**
 * Clasa ParseNutrients reprezinta o implementare a interfetei IParse. Deoarece este gandita flexibilitatea
 * programului si eventuala extindere a functionalitatilor de parsare a query-urilorm de cautare, se foloseste 
 * aceasta implementare. Aceasta clasa primeste in constructor parametrii input si numberRecipes
 * care vor fi parsati intr-un singur string potrivit functiilor de cautare al API-ului.
 * Autor:
 */

namespace ControllerNamespace
{
    class ParseNutrients : IParse
    {
        private Dictionary<string, int> _input = new Dictionary<string, int>();
        int _number;
       
        public ParseNutrients(Dictionary<string, int> input, int numberRecipes)
        {
            _input = input;
            _number = numberRecipes;
        }

        // Metoda CreateQuery implementeaza unica functionalitate a clasei: de a parsa parametrii intr-un query.
        public string CreateQuery()
        {
            string query = "nutrients=";
            query += string.Join("&", _input.Select(elem => elem.Key + "=" + elem.Value));
            query += $"&number={_number}";
            return query;
        }
    }
}
