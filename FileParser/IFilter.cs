using DataModel;

namespace FileParser
{
    public interface IFilter
    {
        RecipeData FilterData();
    }
}