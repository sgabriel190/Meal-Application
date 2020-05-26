

namespace ControllerNamespace
{
    class ParseMealGenerate : IParse
    {
        private string _diet;
        private int _targetCalories;
        private string _excludeInput;

        public ParseMealGenerate(int targetCalories, string diet, string excludeInput)
        {
            this._targetCalories = targetCalories;
            this._diet = diet;
            this._excludeInput = excludeInput;
        }

        public string CreateQuery()
        {
            string query = "";

            if(_targetCalories != 0)
            {
                query += $"&targetCalories={_targetCalories}";
            }

            if (_excludeInput != "")
            {
                query += "&";
                int i;
                string[] words;

                _excludeInput = _excludeInput.Replace(" ", "");
                words = _excludeInput.Split(',');

                for (i = 0; i < words.Length - 1; i++)
                {
                    query += words[i] + ",+";
                }
                query += words[i];
            }

            if (_diet != "")
            {
                query += "&diet=" + _diet;
            }

            return query;
        }
    }
}
