using System.Drawing;

namespace Controller
{
    class RecipeData
    {
        private int _id;
        private string _title;
        private Bitmap _img;
        private string _description;
        private string _url;

        public RecipeData()
        {      
        }

        public RecipeData(int id, string title, Bitmap img, string description)
        {
            _id = id;
            _title = title;
            _img = img;
            _description = description;
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
        public Bitmap Image
        {
            get { return _img; }
            set { _img = value; }
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
