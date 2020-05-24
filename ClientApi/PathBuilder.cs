
namespace ClientApi
{
    public class PathBuilder
    {
        public string buildPathIngredients(string apiKey, string ingredientsQuery, int numberRecipes)
        {
            string path = "recipes/findByIngredients";
            path += "?" + apiKey + "&" + ingredientsQuery + $"&number={numberRecipes}";
            return path;
        }
        public string buildPathNutrients(string apiKey, string nutrientsQuery, int numberRecipes)
        {
            string path = "recipes/findByNutrients";
            path += "?" + apiKey + "&" + nutrientsQuery + $"&number={numberRecipes}";
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
