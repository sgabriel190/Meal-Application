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

            AddNewTab();
        }
        private void AddNewTab()
        {
            TabPage tp = new TabPage();
            DetailedListItem detailedItem = new DetailedListItem();   
            Button button = new Button();

            detailedItem.Size = tabPageSearch.Size;
            string st = "Preparation                                        Make sauce:                Whisk tamarind concentrate into lime juice in a small bowl until dissolved. Stir in remaining sauce ingredients and chill, covered.                                                            Prepare shrimp:                Coarsely chop coconut and transfer half to a shallow soup bowl or pie plate.                                                                Whisk together flour, beer, baking soda, salt, cayenne, and egg in a small bowl until smooth.                                                                Heat oil in a 4- to 6-quart deep heavy pot over moderately high heat until it registers 350°F on thermometer.                                                            While oil is heating, coat shrimp:                Hold 1 shrimp by tail and dip into batter, letting excess drip off, then dredge in coconut, coating completely and pressing gently to help adhere. Transfer to a plate and coat remaining shrimp in same manner, adding remaining coconut to bowl as needed.                                                                Fry shrimp in oil in batches of 8, turning once, until golden, about 1 minute. Transfer with a slotted spoon to paper towels to drain and season lightly with salt. Skim any coconut from oil and return oil to 350°F between batches.                                                                Serve shrimp with sauce.                                                                            * Available at Latino and Indian restaurants and at Kalustyan's (212-685-3451).";
            detailedItem.Instructions = st;
            
            detailedItem.Image = "https://spoonacular.com/recipeImages/284420-312x231.jpg";
            button.Click += (s, ev) => { tabControlSearch.TabPages.Remove(tp); };
            button.Location = new Point(965, 10);
            button.Image = Resources.close_img;
            button.Size = button.Image.Size;

            tp.Controls.Add(button);
            tp.Controls.Add(detailedItem);
            tp.AutoScroll = true;
            tabControlSearch.TabPages.Add(tp);
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
            flowLayoutPanelListItems.Controls.Clear();
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
