using System.Collections.Generic;
using System.Linq;

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
        public string CreateQuery()
        {
            string query=string.Join("&", _input.Select(elem => elem.Key + "=" + elem.Value));
            query += $"&number={_number}";
            return query;
        }
    }
}
