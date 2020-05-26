using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string Title
        {
            get { return _title; }
            set { _title = value; labelTitle.Text = value; }
        }
        public string Info
        {
            get { return _info; }
            set { _info = value; labelInfo.Text = value; }
        }

        public string Image
        {
            get { return _img; }
            set { _img = value; pictureBox.ImageLocation = value; }
        }
        public string URL
        {
            get { return _url; }
            set { _url = value; linkLabel.Text = value; }
        }
        public string Instructions
        {
            get { return _instructions; }
            set { _instructions = value; labelInstructions.Text = value; }
        }
        public string Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; labelIngredients.Text = value; }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(_url);
        }
    }
}
