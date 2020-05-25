
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
    }
}
