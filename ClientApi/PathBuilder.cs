﻿/**
* Clasa PathBuilder este o clasa helper pentru ClientApi in care se construieste 
* resursa apelata la serverul api-ului
* EX: pentru a primi un JSON cu toate informatiile despre id-ul retetei 100 se apeleaza 
* recipes/100/information?apiKey=7b137a9d00974ba4b92d25f4d51d11c6 care va intoarce intr-un
* raspuns HTTP un obiect JSON cu toate informatiile necesare.
* Autor: Strilciuc Gabriel
*/

namespace ClientApi
{
    public class PathBuilder
    {
        // Metoda care construieste resursa specifica functiei SearchByIngredients
        public string BuildPathIngredients(string apiKey, string ingredientsQuery)
        {
            string path = "recipes/findByIngredients";
            path += "?" + apiKey + "&" + ingredientsQuery;
            return path;
        }

        // Metoda care construieste resursa specifica functiei SearchByNutrients
        public string BuildPathNutrients(string apiKey, string nutrientsQuery)
        {
            string path = "recipes/findByNutrients";
            path += "?" + apiKey + "&" + nutrientsQuery;
            return path;
        }

        // Metoda care construieste resursa specifica functiei GetRecipeInformation
        public string BuildPathInformationId(string apiKey, int id)
        {
            string path = $"recipes/{id}/information";
            path += "?" + apiKey + "&includeNutrition=true";
            return path;
        }

        // Metoda care construieste resursa specifica functiei GenerateMealPlan
        public string BuildPathGenerateMealPlan(string apiKey, string mealPlannerQuery)
        {
            string path = "mealplanner/generate";
            //se adauga parametrul timeFrame=day pentru a avea constant planul alimentar pentru o zi
            path += "?" + apiKey + "&timeFrame=day";
            if (mealPlannerQuery != "")
            {
                path += mealPlannerQuery;
            }
            return path;
        }
    }
}
