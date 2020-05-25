using DataModel;
using System.Collections.Generic;

namespace FileParser
{
    public interface IFilter
    {
        RecipeData FilterData();
        RecipeData CompleteData(RecipeData dataToBeCompleted);
        List<RecipeData> FilterMultipleData();
    }
}