
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    class ParseNutrients : IParse
    {
        private Dictionary<string, int> _input = new Dictionary<string, int>();
       
        public ParseNutrients(Dictionary<string, int> input)
        {
            _input = input;
        }
        public string CreateQuery()
        {
            string query=string.Join("&", _input.Select(elem => elem.Key + "=" + elem.Value));
            return query;
        }
    }
}
