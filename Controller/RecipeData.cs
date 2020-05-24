using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
