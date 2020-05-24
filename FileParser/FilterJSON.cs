
using DataModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace FileParser
{
    public class FilterJSON : IFilter
    {
        public RecipeData FilterDataFromID(JObject json)
        {
            throw new System.NotImplementedException();
        }

        public List<RecipeData> FilterDataFromIngredients(JArray json)
        {
            throw new System.NotImplementedException();
        }

        public List<RecipeData> FilterDataFromNutrients(JArray json)
        {
            throw new System.NotImplementedException();
        }
    }
}
