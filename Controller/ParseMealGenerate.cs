

namespace ControllerNamespace
{
    class ParseMealGenerate : IParse
    {
        private string diet;
        private int targetCalories;
        private string excludeInput;

        public ParseMealGenerate(int targetCalories, string diet, string excludeInput)
        {
            this.targetCalories = targetCalories;
            this.diet = diet;
            this.excludeInput = excludeInput;
        }

        public string CreateQuery()
        {
            string query = "";

            if(targetCalories != 0)
            {
                query += $"&targetCalories={targetCalories}";
            }

            if (excludeInput != "")
            {
                query += "&";
                int i;
                string[] words;

                excludeInput = excludeInput.Replace(" ", "");
                words = excludeInput.Split(',');

                for (i = 0; i < words.Length - 1; i++)
                {
                    query += words[i] + ",+";
                }
                query += words[i];
            }

            if (diet != "")
            {
                query += "&diet=" + diet;
            }

            return query;
        }
    }
}
