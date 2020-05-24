
namespace ClientApi
{
    /**
     * Clasa PathBuilder este o clasa helper pentru ClientApi in care se construieste 
     * resursa apelata la serverul api-ului
     * EX: pentru a primi un JSON cu toate informatiile despre id-ul retetei 100 se apeleaza 
     * recipes/100/information?apiKey=7b137a9d00974ba4b92d25f4d51d11c6 care va intoarce intr-un
     * raspuns HTTP un obiect JSON cu toate informatiile necesare.
     */
    public class PathBuilder
    {
        // Metoda care construieste resursa specifica functiei searchByIngredients
        public string BuildPathIngredients(string apiKey, string ingredientsQuery, int numberRecipes)
        {
            string path = "recipes/findByIngredients";
            path += "?" + apiKey + "&" + ingredientsQuery + $"&number={numberRecipes}";
            return path;
        }
        // Metoda care construieste resursa specifica functiei searchByNutrients
        public string BuildPathNutrients(string apiKey, string nutrientsQuery, int numberRecipes)
        {
            string path = "recipes/findByNutrients";
            path += "?" + apiKey + "&" + nutrientsQuery + $"&number={numberRecipes}";
            return path;
        }
        // Metoda care construieste resursa specifica functiei getRecipeInformation
        public string BuildPathInformationId(string apiKey, int id)
        {
            string path = $"recipes/{id}/information";
            path += "?" + apiKey;
            return path;
        }
    }
}
