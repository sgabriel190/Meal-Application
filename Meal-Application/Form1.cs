using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ControllerNamespace;
using DataModel;

namespace Meal_Application
{
    public partial class FormMealApp : Form
    {
        private Controller controller = null;
        ListItem[] previewList = null;


        public FormMealApp()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void FormMealApp_Load(object sender, EventArgs e)
        {
            //tested view list of recipes
            ShowListItems();
            radioButtonIngredients.Checked = true;
        }
        
        private void ShowListItems()
        {
            if (previewList != null)
            {
                for (int i = 0; i < previewList.Length; i++)
                {
                    flowLayoutPanelListItems.Controls.Add(previewList[i]);
                }
            }

        }

        private void checkBoxCarbs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCarbs.Checked)
                groupBoxCarbs.Enabled = true;
            else
                groupBoxCarbs.Enabled = false;
        }

        private void checkBoxProtein_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProtein.Checked)
                groupBoxProtein.Enabled = true;
            else
                groupBoxProtein.Enabled = false;
        }

        private void checkBoxFat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFat.Checked)
                groupBoxFat.Enabled = true;
            else
                groupBoxFat.Enabled = false;
        }

        private void checkBoxCalories_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCalories.Checked)
                groupBoxCalories.Enabled = true;
            else
                groupBoxCalories.Enabled = false;
        }

        private void radioButtonIngredients_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIngredients.Checked)
            {
                textBoxIngredients.Enabled = true;
                groupBoxNutrients.Enabled = false;
            }
            else
                textBoxIngredients.Enabled = false;
        }


        private void radioButtonNutrients_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNutrients.Checked)
            {
                groupBoxNutrients.Enabled = true;
                textBoxIngredients.Enabled = false;
            }
            else
                groupBoxNutrients.Enabled = false;
        }

        private void recipeSearchButton_Click(object sender, EventArgs e)
        {
            
            if(radioButtonIngredients.Checked)
            {
                if(textBoxIngredients.Text == "")
                {
                    MessageBox.Show("You have to add some ingredients.");
                }
                else
                {
                    string ingredientsInput = textBoxIngredients.Text;
                    int numberOfRecipes = Decimal.ToInt32(recipeNumericUpDownSearch.Value);

                    List<RecipeData> recipeList = controller.GetRecipiesFromIngridients(ingredientsInput, numberOfRecipes);
                    previewList = new ListItem[recipeList.Count];
                    for (int i = 0; i < recipeList.Count; ++i)
                    {
                        previewList[i] = new ListItem();
                        previewList[i].Title = recipeList[i].Title;
                        previewList[i].Info = recipeList[i].Description;
                        previewList[i].Image = recipeList[i].ImageLocation;
                    }
                    ShowListItems();
                }
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
                {
                    MessageBox.Show("You have to choose a category of nutrients first.");
                }
            }
        }
    }
}
