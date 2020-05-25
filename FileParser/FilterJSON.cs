using DataModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace FileParser
{
    public class FilterJSON : IFilter
    {
        private JObject objectJSON;
        public RecipeData FilterData()
        {
            throw new System.NotImplementedException();
        }
        public List<RecipeData> FilterMultipleData(JArray arrayDataToFilter)
        {
            return null;
        }
        public RecipeData CompleteData(RecipeData dataToBeCompleted)
        {
            return null;
        }
        public void SetData(JObject objectJSON)
        {
            this.objectJSON = objectJSON;
        }
    }
}
