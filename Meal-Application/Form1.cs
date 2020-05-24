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
            radioButtonIngredients.Checked = true;
        }
        
        private void ShowListItems()
        {
           ListItem[] list = new ListItem[10];
           for(int i=0;i<list.Length;i++)
           {
               list[i] = new ListItem();
               list[i].Title = "Recipe name";
               list[i].Info = "Info";
               list[i].Image = "https://spoonacular.com/recipeImages/284420-312x231.jpg";
               flowLayoutPanelListItems.Controls.Add(list[i]);
           }

        }

        private void checkBoxCarbs_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxCarbs.Checked)
                groupBoxCarbs.Enabled = true;
            else
                groupBoxCarbs.Enabled = false;

        }

        private void checkBoxProtein_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxProtein.Checked)
                groupBoxProtein.Enabled = true;
            else
                groupBoxProtein.Enabled = false;
        }

        private void checkBoxFat_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxFat.Checked)
                groupBoxFat.Enabled = true;
            else
                groupBoxFat.Enabled = false;
        }

        private void checkBoxCalories_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxCalories.Checked)
                groupBoxCalories.Enabled = true;
            else
                groupBoxCalories.Enabled = false;
        }

        private void radioButtonIngredients_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonIngredients.Checked)
            {
                textBoxIngredients.Enabled = true;
                groupBoxNutrients.Enabled = false;
            }
            else
                textBoxIngredients.Enabled = false;

        }


        private void radioButtonNutrients_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonNutrients.Checked)
            {
                groupBoxNutrients.Enabled = true;
                textBoxIngredients.Enabled = false;
            }
            else
                groupBoxNutrients.Enabled = false;

        }
    }
}
