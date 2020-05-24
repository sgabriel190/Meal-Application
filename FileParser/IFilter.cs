using DataModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace FileParser
{
    public interface IFilter
    {
        RecipeData FilterDataFromID(JObject json);
        List<RecipeData> FilterDataFromIngredients(JArray json);
        List<RecipeData> FilterDataFromNutrients(JArray json);
    }
}
