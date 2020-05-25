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
        ListItem[] previewList = null;


        public FormMealApp()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void FormMealApp_Load(object sender, EventArgs e)
        {
            ShowListItems();
            radioButtonIngredients.Checked = true;
            
        }
        private void AddNewTab(int idxSelected)
        {
            DetailedListItem detailedItem = new DetailedListItem();
            string tabName;
            if (previewList[idxSelected].Title.Length > 15) tabName = previewList[idxSelected].Title.Substring(0, 15);
            else
                tabName = previewList[idxSelected].Title;
            TabPage tp = new TabPage(tabName);
            Button button = new Button();

            detailedItem.Size = tabPageSearch.Size;
            detailedItem.Title=previewList[idxSelected].Title;
            detailedItem.Image = previewList[idxSelected].Image;
            detailedItem.Info = previewList[idxSelected].Info;
            //detailedItem.Instructions = ..;
            //detailedItem.URL=...;

            button.Click += (s, ev) => { tabControlSearch.TabPages.Remove(tp); };
            button.Location = new Point(965, 10);
            button.Image = Resources.close_img;
            button.Size = button.Image.Size;

            tp.Controls.Add(button);
            tp.Controls.Add(detailedItem);
            tp.AutoScroll = true;
            tabControlSearch.TabPages.Add(tp);
            tabControlSearch.SelectedTab=tp;

           
        }
        private void ShowListItems()
        {
            flowLayoutPanelListItems.Controls.Clear();
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
                    List<RecipeData> recipeList = controller.GetRecipiesFromIngridients(ingredientsInput, numberOfRecipes);
                    
                    refreshPreviewList(recipeList);
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
                    List<RecipeData> recipeList = controller.GetRecipiesFromNutrients(_nutrients, numberOfRecipes);

                    refreshPreviewList(recipeList);
                }
            }
        }

        private void refreshPreviewList(List<RecipeData> recipeList)
        {
            previewList = new ListItem[recipeList.Count];
            for (int i = 0; i < recipeList.Count; ++i)
            {
                previewList[i] = new ListItem();
                previewList[i].ID = recipeList[i].ID;
                previewList[i].Title = recipeList[i].Title;
                previewList[i].Info = recipeList[i].Description;
                previewList[i].Image = recipeList[i].ImageLocation;
                int idx = i;
                previewList[i].ClickEvent = (s, ev) => {  AddNewTab(idx); };
            }
            ShowListItems();
        }

    }
}
