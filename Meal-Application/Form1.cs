using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControllerNamespace;
using DataModel;
using Meal_Application.Properties;

namespace Meal_Application
{
    public partial class FormMealApp : Form
    {
        private Controller controller = null;
        private ListItem[] previewList = null;
        private List<RecipeData> recipesList = null;
        private List<RecipeData> generatedMealList = null;


        public FormMealApp()
        {
            InitializeComponent();
            controller = new Controller();
            recipesList = new List<RecipeData>();
            generatedMealList = new List<RecipeData>();
        }

        private void FormMealApp_Load(object sender, EventArgs e)
        {
            radioButtonIngredients.Checked = true;       
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
        private void AddNewTab(RecipeData recipe)
        {
            recipe = controller.GetCompleteRecipe(recipe);
            DetailedListItem detailedItem = new DetailedListItem();
            string tabName;
            if (recipe.Title.Length > 15) tabName = recipe.Title.Substring(0, 15) + "...";
            else
                tabName = recipe.Title;
            TabPage tp = new TabPage(tabName);
            Button button = new Button();

            detailedItem.Size = tabPageSearch.Size;
            detailedItem.Title = recipe.Title;
            detailedItem.Image = recipe.ImageLocation;
            detailedItem.Info = recipe.Description;
            detailedItem.Instructions = recipe.Instructions;
            detailedItem.URL = recipe.URL;

            button.Click += (s, ev) => { tabControlSearch.TabPages.Remove(tp); };
            button.Location = new Point(965, 10);
            button.Image = Resources.close_img;
            button.Size = button.Image.Size;

            tp.Controls.Add(button);
            tp.Controls.Add(detailedItem);
            tp.AutoScroll = true;
            tabControlSearch.TabPages.Add(tp);
            tabControlSearch.SelectedTab = tp;
        }
        /*private void ShowListItems()
        {
            flowLayoutPanelListItems.Controls.Clear();
            if (previewList != null)
            {
                for (int i = 0; i < previewList.Length; i++)
                {
                    flowLayoutPanelListItems.Controls.Add(previewList[i]);
                }
            }
        }*/

        private void refreshPreviewList()
        {
            previewList = new ListItem[recipesList.Count];
            for (int i = 0; i < recipesList.Count; ++i)
            {
                previewList[i] = new ListItem();
                previewList[i].ID = recipesList[i].ID;
                previewList[i].Title = recipesList[i].Title;
                previewList[i].Info = recipesList[i].Description;
                previewList[i].Image = recipesList[i].ImageLocation;
                int idx = i;
                previewList[i].ClickEvent = (s, ev) => { AddNewTab(recipesList[idx]); };

                flowLayoutPanelListItems.Controls.Add(previewList[i]);
            }
        }

        private void refreshPreviewMealList()
        {

            previewList = new ListItem[generatedMealList.Count];
            for (int i = 0; i < generatedMealList.Count; ++i)
            {
                previewList[i] = new ListItem();
                previewList[i].ID = generatedMealList[i].ID;
                previewList[i].Title = generatedMealList[i].Title;
                previewList[i].Info = generatedMealList[i].Description;
                previewList[i].Image = generatedMealList[i].ImageLocation;
                int idx = i;
                previewList[i].ClickEvent = (s, ev) => { AddNewTab(generatedMealList[idx]); };

                previewList[i].SeparatorSize = flowLayoutPanelMealPlan.Width;
                previewList[i].Width = flowLayoutPanelMealPlan.Width;
                flowLayoutPanelMealPlan.Controls.Add(previewList[i]);
            }
        }
        private void recipeSearchButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanelListItems.Controls.Clear();
            if (radioButtonIngredients.Checked)
            {
                if (textBoxIngredients.Text == "")
                {
                    MessageBox.Show("You have to add some ingredients.");
                }
                else
                {
                    string ingredientsInput = textBoxIngredients.Text;
                    int numberOfRecipes = Decimal.ToInt32(recipeNumericUpDownSearch.Value);

                    recipesList = controller.GetRecipiesFromIngridients(ingredientsInput, numberOfRecipes);
                    if (recipesList.Count == 0)
                    {
                        Label l = new Label();
                        l.Text = "No results.";
                        flowLayoutPanelListItems.Controls.Add(l); 
                    }

                    else refreshPreviewList();
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
                if (checkBoxProtein.Checked)
                {
                    _nutrients["minProtein"] = Decimal.ToInt32(numericUpDownMinProtein.Value);
                    _nutrients["maxProtein"] = Decimal.ToInt32(numericUpDownMaxProtein.Value);
                }
                if (checkBoxFat.Checked)
                {
                    _nutrients["minFat"] = Decimal.ToInt32(numericUpDownMinFat.Value);
                    _nutrients["maxFat"] = Decimal.ToInt32(numericUpDownMaxFat.Value);
                }
                if (checkBoxCalories.Checked)
                {
                    _nutrients["minCalories"] = Decimal.ToInt32(numericUpDownMinCalories.Value);
                    _nutrients["maxCalories"] = Decimal.ToInt32(numericUpDownMaxCalories.Value);
                }
                if (_nutrients.Count == 0)
                {
                    MessageBox.Show("You have to choose a category of nutrients first.");
                }
                else
                {
                    int numberOfRecipes = Decimal.ToInt32(recipeNumericUpDownSearch.Value);
                    recipesList = controller.GetRecipiesFromNutrients(_nutrients, numberOfRecipes);

                    refreshPreviewList();
                }
            }
        }
      
        private void buttonGenerateMealPlan_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMealPlan.Controls.Clear();
            if (textBoxCalories.Text == "")
            {
                MessageBox.Show("You have to input atleast calories number.");
            }
            else
            {
                generatedMealList = controller.GetRecipesMealPlan(Int32.Parse(textBoxCalories.Text), comboBoxDiet.Text, textBoxExcludeIng.Text);

                refreshPreviewMealList();
            }
        }
    }
}
