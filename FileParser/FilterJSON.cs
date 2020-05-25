using DataModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace FileParser
{
    public class FilterJSON : IFilter
    {
        private JObject objectJSON;
        public RecipeData FilterData()
        {
            return new RecipeData(Int32.Parse(objectJSON.GetValue("id").ToString()), objectJSON.GetValue("title").ToString(),
                objectJSON.GetValue("image").ToString(), "Likes :" + objectJSON.GetValue("likes").ToString());
        }
        public List<RecipeData> FilterMultipleData(JArray arrayDataToFilter)
        {
            List<RecipeData> dataList = new List<RecipeData>();
            foreach (JObject JSONobj in arrayDataToFilter)
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
                        "\tProteins: " + JSONobj.GetValue("protein").ToString() +
                        "\tCarbs: " + JSONobj.GetValue("carbs").ToString() +
                        "\tFat: " + JSONobj.GetValue("fat").ToString();
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
            if (objectJSON.ContainsKey("sourceURL"))
            {
                dataToBeCompleted.Instructions = objectJSON.GetValue("sourceURL").ToString();
            }
            return dataToBeCompleted;
        }
        public void SetData(JObject objectJSON)
        {
            this.objectJSON = objectJSON;
        }
    }
}
