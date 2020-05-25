using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Meal_Application
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private string _title;
        private string _info;
        private string _img;
  
        public string Title
        {
            get { return _title; }
            set { _title = value; labelListItemTitle.Text = value; }
        }
        public string Info
        {
            get { return _info; }
            set { _info = value; labelListItemInfo.Text = value; }
        } 

        public string Image
        {
            get { return _img; }
            set { _img = value; pictureBoxListItem.ImageLocation = value; }
        }

    }
}
