using System.Windows.Forms;

namespace Meal_Application
{
    public partial class FormMealApp : Form
    {
        public FormMealApp()
        {
            InitializeComponent();
        }

        private void FormMealApp_Load(object sender, System.EventArgs e)
        {
            //tested view list of recipes
            ShowListItems();
        }
        
        private void ShowListItems()
        {
           ListItem[] list = new ListItem[20];
           for(int i=0;i<list.Length;i++)
           {
               list[i] = new ListItem();
               list[i].Title = "Recipe name";
                list[i].Info = "Info";
               flowLayoutPanelListItems.Controls.Add(list[i]);
           }

        }

    }
}
