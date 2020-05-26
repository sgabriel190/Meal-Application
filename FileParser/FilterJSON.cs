using DataModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace FileParser
{
    public class FilterJSON : IFilter
    {
        private JObject objectJSON;
        private JArray arrayJSON;

        public FilterJSON(JArray arrayJSON)
        {
            this.arrayJSON = arrayJSON;
        }
        public FilterJSON(JObject objectJSON)
        {
            this.objectJSON = objectJSON;
        }
        public RecipeData FilterData()
        {
            return new RecipeData(Int32.Parse(objectJSON.GetValue("id").ToString()), objectJSON.GetValue("title").ToString(),
                 objectJSON.GetValue("image").ToString(), "Source name: " + objectJSON.GetValue("sourceName").ToString());
        }
        public List<RecipeData> FilterMultipleData()
        {
            List<RecipeData> dataList = new List<RecipeData>();
            foreach (JObject JSONobj in arrayJSON)
            {
                RecipeData dataCreated = new RecipeData();

                dataCreated.Title = JSONobj.GetValue("title").ToString();
                dataCreated.ID = Int32.Parse(JSONobj.GetValue("id").ToString());
                dataCreated.ImageLocation = JSONobj.GetValue("image").ToString();
                if(JSONobj.ContainsKey("likes"))
                {
                    dataCreated.Description = "Likes: " + JSONobj.GetValue("likes").ToString();
                }
                else if(JSONobj.ContainsKey("calories") && JSONobj.ContainsKey("carbs"))
                {
                    dataCreated.Description = "Calories: " + JSONobj.GetValue("calories").ToString() +
                        "   Proteins: " + JSONobj.GetValue("protein").ToString() +
                        "   Carbs: " + JSONobj.GetValue("carbs").ToString() +
                        "   Fat: " + JSONobj.GetValue("fat").ToString();
                }
                dataList.Add(dataCreated);
            }
            return dataList;
        }
        public RecipeData CompleteData(RecipeData dataToBeCompleted)
        {
            if (objectJSON.ContainsKey("instructions"))
            {
                dataToBeCompleted.Instructions = objectJSON.GetValue("instructions").ToString();
            }
            if (objectJSON.ContainsKey("sourceUrl"))
            {
                dataToBeCompleted.URL = objectJSON.GetValue("sourceUrl").ToString();
            }
            JObject nutrition = (JObject)objectJSON.GetValue("nutrition");
            JArray nutrients = (JArray)nutrition.GetValue("nutrients");
            JArray ingredients = (JArray)nutrition.GetValue("ingredients");
            string nutrientsString = "Nutrients: \n", ingredientsString = "Ingredients: \n";
            foreach(JObject nutrient in nutrients)
            {
                nutrientsString += nutrient.GetValue("title").ToString()+ ": "+
                    nutrient.GetValue("amount").ToString() +
                    nutrient.GetValue("unit").ToString() + " | ";
            }
            foreach (JObject ingredient in ingredients)
            {
                ingredientsString += ingredient.GetValue("name").ToString() + ": " +
                    ingredient.GetValue("amount").ToString() + " " + ingredient.GetValue("unit").ToString() + Environment.NewLine;
            }
            ingredientsString = ingredientsString.Substring(0, ingredientsString.Length - 2);
            nutrientsString = nutrientsString.Substring(0, nutrientsString.Length - 2);
            dataToBeCompleted.Nutrients = nutrientsString;
            dataToBeCompleted.Ingredients = ingredientsString;

            return dataToBeCompleted;
        }
    }
}
