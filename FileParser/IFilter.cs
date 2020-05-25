using DataModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace FileParser
{
    public interface IFilter
    {
        RecipeData FilterData();
    }
}