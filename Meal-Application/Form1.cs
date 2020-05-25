using System;
using System.Collections.Generic;
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

        private void recipeSearchButton_Click(object sender, System.EventArgs e)
        {
            
            if(radioButtonIngredients.Checked)
            {

            }
            else if(radioButtonNutrients.Checked)
            {
                Dictionary<string, int> _nutrients = new Dictionary<string, int>();
                if (checkBoxCarbs.Checked)
                {
                    _nutrients["minCarbs"] = Decimal.ToInt32(numericUpDownMinCarbs.Value);
                    _nutrients["maxCarbs"] = Decimal.ToInt32(numericUpDownMaxCarbs.Value);
                }
                if(checkBoxProtein.Checked)
                {
                    _nutrients["minProtein"] = Decimal.ToInt32(numericUpDownMinProtein.Value);
                    _nutrients["maxProtein"] = Decimal.ToInt32(numericUpDownMaxProtein.Value);
                }
                if(checkBoxFat.Checked)
                {
                    _nutrients["minFat"] = Decimal.ToInt32(numericUpDownMinFat.Value);
                    _nutrients["maxFat"] = Decimal.ToInt32(numericUpDownMaxFat.Value);
                }
                if(checkBoxCalories.Checked)
                {
                    _nutrients["minCalories"] = Decimal.ToInt32(numericUpDownMinCalories.Value);
                    _nutrients["maxCalories"] = Decimal.ToInt32(numericUpDownMaxCalories.Value);
                }
                if (_nutrients.Count == 0)
                    MessageBox.Show("You have to choose a category of nutrients first.");
            }
        }
    }
}
