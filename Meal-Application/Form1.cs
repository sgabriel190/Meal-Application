using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControllerNamespace;
using DataModel;
using Meal_Application.Properties;
/**
 * Clasa FormMealApp defineste interfata impreuna cu functionalitatile oferite de aceasta(callback-uri).
 * Interfata este realizata sub modelul de Windows Form App oferit in Visual Studio.
 * Autor: Panainte Ancuta
 */

namespace Meal_Application
{
    public partial class FormMealApp : Form
    {
        private Controller _controller = null;
        private ListItem[] _previewList = null;
        private List<RecipeData> _recipesList = null;
        private List<RecipeData> _generatedMealList = null;

        // Constructorul ce initializeaza interfata
        public FormMealApp()
        {
            InitializeComponent();
            _controller = new Controller();
            _recipesList = new List<RecipeData>();
            _generatedMealList = new List<RecipeData>();
        }

        private void FormMealApp_Load(object sender, EventArgs e)
        {
            radioButtonIngredients.Checked = true;
            textBoxApiKey.GotFocus += textBoxApiKey_OnFocus;
            textBoxApiKeyTab2.GotFocus+=textBoxApiKeyTab2_OnFocus;
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

        // Metoda pentru adaugarea unui tab nou 
        private void AddNewTab(RecipeData recipe)
        {
            recipe = _controller.GetCompleteRecipe(recipe);
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
            detailedItem.Instructions = recipe.Instructions + "\n\n"+ recipe.Nutrients;
            detailedItem.Ingredients = recipe.Ingredients;
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

        // Metoda refreshPreviewList actualizeaza lista de retete din tabul Search
        private void refreshPreviewList()
        {
            _previewList = new ListItem[_recipesList.Count];
            for (int i = 0; i < _recipesList.Count; ++i)
            {
                _previewList[i] = new ListItem();
                _previewList[i].ID = _recipesList[i].ID;
                _previewList[i].Title = _recipesList[i].Title;
                _previewList[i].Info = _recipesList[i].Description;
                _previewList[i].Image = _recipesList[i].ImageLocation;
                int idx = i;
                _previewList[i].ClickEvent = (s, ev) => { AddNewTab(_recipesList[idx]); };

                flowLayoutPanelListItems.Controls.Add(_previewList[i]);
            }
        }

        // Metoda refreshPreviewMealList actualizeaza lista de retete din tabul Meal Plan
        private void refreshPreviewMealList()
        {

            _previewList = new ListItem[_generatedMealList.Count];
            for (int i = 0; i < _generatedMealList.Count; ++i)
            {
                _previewList[i] = new ListItem();
                _previewList[i].ID = _generatedMealList[i].ID;
                _previewList[i].Title = _generatedMealList[i].Title;
                _previewList[i].Info = _generatedMealList[i].Description;
                _previewList[i].Image = _generatedMealList[i].ImageLocation;
                int idx = i;
                _previewList[i].ClickEvent = (s, ev) => { AddNewTab(_generatedMealList[idx]); };

                _previewList[i].SeparatorSize = flowLayoutPanelMealPlan.Width;
                _previewList[i].Width = flowLayoutPanelMealPlan.Width;
                flowLayoutPanelMealPlan.Controls.Add(_previewList[i]);
            }
        }

        // Metoda de callback pentru butonul Search
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
                    try 
                    { 
                        _recipesList = _controller.GetRecipiesFromIngridients(ingredientsInput, numberOfRecipes); 
                        if (_recipesList.Count == 0)
                        {
                            Label l = new Label();
                            l.Text = "No results.";
                            flowLayoutPanelListItems.Controls.Add(l);
                        }

                        else refreshPreviewList();
                    }
                    catch(Exception err)
                    { 
                        MessageBox.Show(err.Message); 
                    }
                    
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
                    try
                    {
                        _recipesList = _controller.GetRecipiesFromNutrients(_nutrients, numberOfRecipes);
                        refreshPreviewList();
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        // Metoda de callback pentru butonul Generate din tabul Meal Plan
        private void buttonGenerateMealPlan_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMealPlan.Controls.Clear();
            if (textBoxCalories.Text == "")
            {
                MessageBox.Show("You have to input atleast calories number.");
            }
            else
            {
                try
                {
                    int nrCalories = Int32.Parse(textBoxCalories.Text);
                    _generatedMealList = _controller.GetRecipesMealPlan(nrCalories, comboBoxDiet.Text, textBoxExcludeIng.Text);
                    refreshPreviewMealList();
                }
                catch(FormatException err)
                {
                    MessageBox.Show("You have to input a number.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }

        // Metoda de callback pentru butonul Change din tabul Search pentru actualizarea api keyului
        private void buttonChangeApiKey_Click(object sender, EventArgs e)
        {
            _controller.SetApiKey(textBoxApiKey.Text);
        }

        private void buttonApiKeyTab2_Click(object sender, EventArgs e)
        {
            _controller.SetApiKey(textBoxApiKeyTab2.Text);
        }
        protected void textBoxApiKey_OnFocus(Object sender, EventArgs e)
        {
            textBoxApiKey.Text = "";
            textBoxApiKey.ForeColor = System.Drawing.Color.Black;
        }
        protected void textBoxApiKeyTab2_OnFocus(Object sender, EventArgs e)
        {
            textBoxApiKeyTab2.Text = "";
            textBoxApiKeyTab2.ForeColor = System.Drawing.Color.Black;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meal Plan based on preference and diet type." + "\n\n" + "Add ingredients and nutriens to get personalized recipes."
                + "\n\n" + "(c) 2020 Proiect");
        }

    }
}
