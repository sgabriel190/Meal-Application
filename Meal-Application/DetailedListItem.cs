using System.Windows.Forms;
/**
    * Definire UserControl DetailedListItem, utilizat pentru a dispune pe interfata retetele complete.
    * Un astfel de control va fi creat la deschiderea unui nou tab.
    * Autor: Panainte Ancuta
    */

namespace Meal_Application
{
    
    public partial class DetailedListItem : UserControl
    {
        public DetailedListItem()
        {
            InitializeComponent();
        }
        
        private string _title;
        private string _info;
        private string _img;
        private string _url;
        private string _instructions;
        private string _ingredients;

        /// <summary>
        /// Camp care va fi populat cu atributele din RecipeData.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; labelTitle.Text = value; }
        }

        /// <summary>
        /// Camp care va fi populat cu atributele din RecipeData.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set { _info = value; labelInfo.Text = value; }
        }

        /// <summary>
        /// Camp care va fi populat cu atributele din RecipeData.
        /// </summary>
        public string Image
        {
            get { return _img; }
            set { _img = value; pictureBox.ImageLocation = value; }
        }

        /// <summary>
        /// Camp care va fi populat cu atributele din RecipeData.
        /// </summary>
        public string URL
        {
            get { return _url; }
            set { _url = value; linkLabel.Text = value; }
        }

        /// <summary>
        /// Camp care va fi populat cu atributele din RecipeData.
        /// </summary>
        public string Instructions
        {
            get { return _instructions; }
            set { _instructions = value; labelInstructions.Text = value; }
        }

        /// <summary>
        /// Camp care va fi populat cu atributele din RecipeData.
        /// </summary>
        public string Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; labelIngredients.Text = value; }
        }

        /// <summary>
        /// Metoda de callback pentru deschiderea linkului
        /// </summary>
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(_url);
        }
    }
}
