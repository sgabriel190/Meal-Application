using System.Collections.Generic;

namespace ClientApi
{
    public class PathBuilder
    {
        public string buildPathIngredients(string apiKey, Dictionary<string, Dictionary<string, int>> parameters)
        {
            string path = "recipes/findByIngredients";
            path += "?" + apiKey;
            return path;
        }
        public string buildPathNutrients(string apiKey, Dictionary<string, Dictionary<string, int>> parameters)
        {
            string path = "recipes/findByNutrients";
            path += "?" + apiKey;
            return path;
        }
        public string buildPathInformationId(string apiKey, int id)
        {
            string path = $"recipes/{id}/information";
            path += "?" + apiKey;
            return path;
        }
    }
}
