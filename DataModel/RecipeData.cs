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
 * Autor: Georgiana Raschitor
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

        /// <summary>
        /// Definirea functiilor getter si setter pentru campul Instructions.
        /// </summary>
        public string Instructions
        {
            get { return _instructions; }
            set { _instructions = value; }
        }

        /// <summary>
        /// Definirea functiilor getter si setter pentru campul ID.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Definirea functiilor getter si setter pentru campul Title.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Definirea functiilor getter si setter pentru campul ImageLocation.
        /// </summary>
        public string ImageLocation
        {
            get { return _imgLocation; }
            set { _imgLocation = value; }
        }

        /// <summary>
        /// Definirea functiilor getter si setter pentru campul Description.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        /// Definirea functiilor getter si setter pentru campul URL.
        /// </summary>
        public string URL
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// Definirea functiilor getter si setter pentru campul Nutrients.
        /// </summary>
        public string Nutrients
        {
            get { return _nutrients; }
            set { _nutrients = value; }
        }

        /// <summary>
        /// Definirea functiilor getter si setter pentru campul Ingredients.
        /// </summary>
        public string Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }
    }
}
