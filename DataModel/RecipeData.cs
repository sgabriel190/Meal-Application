/**
 * Clasa RecipeData reprezinta un model de data convenabil aplicatiei. Datele aceste clase sunt populate
 * conform raspunsurilor primite de la API ale retetelor.
 * Datele folosite pentru retete sunt:
 * id: int
 * title: string
 * imgLocation: string
 * description: string
 * url: string
 * instructions: string
 * nutrients: string
 * ingredients: string
 * Autor:
 */

namespace DataModel
{
    public class RecipeData
    {
        private int _id;
        private string _title;
        private string _imgLocation;
        private string _description;
        private string _url;
        private string _instructions;
        private string _nutrients;
        private string _ingredients;


        public RecipeData()
        {      
        }

        public RecipeData(int id, string title, string imgLocation, string description)
        {
            _id = id;
            _title = title;
            _imgLocation = imgLocation;
            _description = description;
        }

        /**
         * Definirea metodelor getter si setter pentru atributele clasei
         */
        public string Instructions
        {
            get { return _instructions; }
            set { _instructions = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string ImageLocation
        {
            get { return _imgLocation; }
            set { _imgLocation = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string URL
        {
            get { return _url; }
            set { _url = value; }
        }
        public string Nutrients
        {
            get { return _nutrients; }
            set { _nutrients = value; }
        }
        public string Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }
    }
}
