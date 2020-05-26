using DataModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
/**
 * Clasa FilterJSON are ca functionalitate filtrarea datelor dintr-un fisier/obiect JSON.
 * Extrage datele dintr-un obiect/array JSON si le formateaza intr-un model de date stabilit.
 * Autor: Strilciuc Gabriel
 */

namespace FileParser
{
    public class FilterJSON : IFilter
    {
        private JObject _objectJSON;
        private JArray _arrayJSON;

        public FilterJSON(JArray arrayJSON)
        {
            this._arrayJSON = arrayJSON;
        }
        public FilterJSON(JObject objectJSON)
        {
            this._objectJSON = objectJSON;
        }

        // Metoda FilterData care extrage datele primare despre reteta
        public RecipeData FilterData()
        {
            return new RecipeData(Int32.Parse(_objectJSON.GetValue("id").ToString()), _objectJSON.GetValue("title").ToString(),
                 _objectJSON.GetValue("image").ToString(), "Source name: " + _objectJSON.GetValue("sourceName").ToString());
        }
        
        // Metoda FilterMultipleData extrage date dintr-un array JSON
        public List<RecipeData> FilterMultipleData()
        {
            List<RecipeData> dataList = new List<RecipeData>();
            foreach (JObject JSONobj in _arrayJSON)
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

        // Metoda CompleteData completeaza un model de date incomplet cu informatii suplimentare
        public RecipeData CompleteData(RecipeData dataToBeCompleted)
        {
            if (_objectJSON.ContainsKey("instructions"))
            {
                dataToBeCompleted.Instructions = _objectJSON.GetValue("instructions").ToString();
            }
            if (_objectJSON.ContainsKey("sourceUrl"))
            {
                dataToBeCompleted.URL = _objectJSON.GetValue("sourceUrl").ToString();
            }
            JObject nutrition = (JObject)_objectJSON.GetValue("nutrition");
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
