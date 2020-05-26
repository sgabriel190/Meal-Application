/**
 * Clasa ParseMealGenerate reprezinta o implementare a interfetei IParse. Deoarece este gandita flexibilitatea
 * programului si eventuala extindere a functionalitatilor de parsare a query-urilorm de cautare, se foloseste 
 * aceasta implementare. Aceasta clasa primeste in constructor parametrii targetCalories, diet si excludeInput
 * care vor fi parsati intr-un singur string potrivit functiilor de cautare al API-ului.
 * Autor: Cotovanu Stefania
 */

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

        // Metoda CreateQuery implementeaza unica functionalitate a clasei: de a parsa parametrii intr-un query.
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
