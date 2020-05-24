namespace Meal_Application
{
    partial class FormMealApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlSearch = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxCalories = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinCalories = new System.Windows.Forms.NumericUpDown();
            this.labelMinCalories = new System.Windows.Forms.Label();
            this.labelMaxCalories = new System.Windows.Forms.Label();
            this.numericUpDownMaxCalories = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCalories = new System.Windows.Forms.CheckBox();
            this.groupBoxFat = new System.Windows.Forms.GroupBox();
            this.labelMinFat = new System.Windows.Forms.Label();
            this.numericUpDownMinFat = new System.Windows.Forms.NumericUpDown();
            this.labelMaxFat = new System.Windows.Forms.Label();
            this.numericUpDownMaxFat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxFat = new System.Windows.Forms.CheckBox();
            this.groupBoxProtein = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinProtein = new System.Windows.Forms.NumericUpDown();
            this.labelMinProtein = new System.Windows.Forms.Label();
            this.labelMaxProtein = new System.Windows.Forms.Label();
            this.numericUpDownMaxProtein = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxProtein = new System.Windows.Forms.CheckBox();
            this.groupBoxCarbs = new System.Windows.Forms.GroupBox();
            this.labelMinCarbs = new System.Windows.Forms.Label();
            this.numericUpDownMinCarbs = new System.Windows.Forms.NumericUpDown();
            this.labelMaxCarbs = new System.Windows.Forms.Label();
            this.numericUpDownMaxCarbs = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxCarbs = new System.Windows.Forms.CheckBox();
            this.comboBoxCuisine = new System.Windows.Forms.ComboBox();
            this.labelCuisine = new System.Windows.Forms.Label();
            this.labelProtein = new System.Windows.Forms.Label();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.recipeNumericUpDownSearch = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelListItems = new System.Windows.Forms.FlowLayoutPanel();
            this.recipeSearchButton = new System.Windows.Forms.Button();
            this.recipeTextBoxSearch = new System.Windows.Forms.TextBox();
            this.tabPageMealPlan = new System.Windows.Forms.TabPage();
            this.buttonGenerateMealPlan = new System.Windows.Forms.Button();
            this.flowLayoutPanelMealPlan = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxDiet = new System.Windows.Forms.ComboBox();
            this.textBoxExcludeIng = new System.Windows.Forms.TextBox();
            this.labelExcludeIng = new System.Windows.Forms.Label();
            this.labelDiet = new System.Windows.Forms.Label();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelMealPlan = new System.Windows.Forms.Label();
            this.tabControlSearch.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxCalories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCalories)).BeginInit();
            this.groupBoxFat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFat)).BeginInit();
            this.groupBoxProtein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxProtein)).BeginInit();
            this.groupBoxCarbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeNumericUpDownSearch)).BeginInit();
            this.tabPageMealPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Controls.Add(this.tabPageSearch);
            this.tabControlSearch.Controls.Add(this.tabPageMealPlan);
            this.tabControlSearch.Location = new System.Drawing.Point(39, 12);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(1019, 618);
            this.tabControlSearch.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.splitContainer1);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1011, 592);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCalories);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxCalories);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxFat);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxFat);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxProtein);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxProtein);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCarbs);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxCarbs);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxCuisine);
            this.splitContainer1.Panel1.Controls.Add(this.labelCuisine);
            this.splitContainer1.Panel1.Controls.Add(this.labelProtein);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIngredients);
            this.splitContainer1.Panel1.Controls.Add(this.labelIngredients);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.recipeNumericUpDownSearch);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelListItems);
            this.splitContainer1.Panel2.Controls.Add(this.recipeSearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.recipeTextBoxSearch);
            this.splitContainer1.Size = new System.Drawing.Size(1005, 586);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxCalories
            // 
            this.groupBoxCalories.Controls.Add(this.numericUpDownMinCalories);
            this.groupBoxCalories.Controls.Add(this.labelMinCalories);
            this.groupBoxCalories.Controls.Add(this.labelMaxCalories);
            this.groupBoxCalories.Controls.Add(this.numericUpDownMaxCalories);
            this.groupBoxCalories.Enabled = false;
            this.groupBoxCalories.Location = new System.Drawing.Point(21, 429);
            this.groupBoxCalories.Name = "groupBoxCalories";
            this.groupBoxCalories.Size = new System.Drawing.Size(278, 61);
            this.groupBoxCalories.TabIndex = 34;
            this.groupBoxCalories.TabStop = false;
            // 
            // numericUpDownMinCalories
            // 
            this.numericUpDownMinCalories.Location = new System.Drawing.Point(35, 22);
            this.numericUpDownMinCalories.Name = "numericUpDownMinCalories";
            this.numericUpDownMinCalories.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownMinCalories.TabIndex = 13;
            this.numericUpDownMinCalories.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelMinCalories
            // 
            this.labelMinCalories.AutoSize = true;
            this.labelMinCalories.Location = new System.Drawing.Point(6, 24);
            this.labelMinCalories.Name = "labelMinCalories";
            this.labelMinCalories.Size = new System.Drawing.Size(27, 13);
            this.labelMinCalories.TabIndex = 14;
            this.labelMinCalories.Text = "Min:";
            // 
            // labelMaxCalories
            // 
            this.labelMaxCalories.AutoSize = true;
            this.labelMaxCalories.Location = new System.Drawing.Point(136, 24);
            this.labelMaxCalories.Name = "labelMaxCalories";
            this.labelMaxCalories.Size = new System.Drawing.Size(30, 13);
            this.labelMaxCalories.TabIndex = 15;
            this.labelMaxCalories.Text = "Max:";
            // 
            // numericUpDownMaxCalories
            // 
            this.numericUpDownMaxCalories.Location = new System.Drawing.Point(170, 22);
            this.numericUpDownMaxCalories.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxCalories.Name = "numericUpDownMaxCalories";
            this.numericUpDownMaxCalories.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownMaxCalories.TabIndex = 16;
            this.numericUpDownMaxCalories.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // checkBoxCalories
            // 
            this.checkBoxCalories.AutoSize = true;
            this.checkBoxCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCalories.Location = new System.Drawing.Point(21, 409);
            this.checkBoxCalories.Name = "checkBoxCalories";
            this.checkBoxCalories.Size = new System.Drawing.Size(80, 20);
            this.checkBoxCalories.TabIndex = 33;
            this.checkBoxCalories.Text = "Calories:";
            this.checkBoxCalories.UseVisualStyleBackColor = true;
            // 
            // groupBoxFat
            // 
            this.groupBoxFat.Controls.Add(this.labelMinFat);
            this.groupBoxFat.Controls.Add(this.numericUpDownMinFat);
            this.groupBoxFat.Controls.Add(this.labelMaxFat);
            this.groupBoxFat.Controls.Add(this.numericUpDownMaxFat);
            this.groupBoxFat.Enabled = false;
            this.groupBoxFat.Location = new System.Drawing.Point(21, 342);
            this.groupBoxFat.Name = "groupBoxFat";
            this.groupBoxFat.Size = new System.Drawing.Size(278, 61);
            this.groupBoxFat.TabIndex = 31;
            this.groupBoxFat.TabStop = false;
            // 
            // labelMinFat
            // 
            this.labelMinFat.AutoSize = true;
            this.labelMinFat.Location = new System.Drawing.Point(6, 24);
            this.labelMinFat.Name = "labelMinFat";
            this.labelMinFat.Size = new System.Drawing.Size(27, 13);
            this.labelMinFat.TabIndex = 19;
            this.labelMinFat.Text = "Min:";
            // 
            // numericUpDownMinFat
            // 
            this.numericUpDownMinFat.Location = new System.Drawing.Point(35, 22);
            this.numericUpDownMinFat.Name = "numericUpDownMinFat";
            this.numericUpDownMinFat.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownMinFat.TabIndex = 18;
            this.numericUpDownMinFat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMaxFat
            // 
            this.labelMaxFat.AutoSize = true;
            this.labelMaxFat.Location = new System.Drawing.Point(136, 24);
            this.labelMaxFat.Name = "labelMaxFat";
            this.labelMaxFat.Size = new System.Drawing.Size(30, 13);
            this.labelMaxFat.TabIndex = 20;
            this.labelMaxFat.Text = "Max:";
            // 
            // numericUpDownMaxFat
            // 
            this.numericUpDownMaxFat.Location = new System.Drawing.Point(170, 22);
            this.numericUpDownMaxFat.Name = "numericUpDownMaxFat";
            this.numericUpDownMaxFat.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownMaxFat.TabIndex = 21;
            this.numericUpDownMaxFat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Protein:";
            // 
            // checkBoxFat
            // 
            this.checkBoxFat.AutoSize = true;
            this.checkBoxFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFat.Location = new System.Drawing.Point(21, 322);
            this.checkBoxFat.Name = "checkBoxFat";
            this.checkBoxFat.Size = new System.Drawing.Size(49, 20);
            this.checkBoxFat.TabIndex = 30;
            this.checkBoxFat.Text = "Fat:";
            this.checkBoxFat.UseVisualStyleBackColor = true;
            // 
            // groupBoxProtein
            // 
            this.groupBoxProtein.Controls.Add(this.numericUpDownMinProtein);
            this.groupBoxProtein.Controls.Add(this.labelMinProtein);
            this.groupBoxProtein.Controls.Add(this.labelMaxProtein);
            this.groupBoxProtein.Controls.Add(this.numericUpDownMaxProtein);
            this.groupBoxProtein.Enabled = false;
            this.groupBoxProtein.Location = new System.Drawing.Point(21, 255);
            this.groupBoxProtein.Name = "groupBoxProtein";
            this.groupBoxProtein.Size = new System.Drawing.Size(278, 61);
            this.groupBoxProtein.TabIndex = 28;
            this.groupBoxProtein.TabStop = false;
            // 
            // numericUpDownMinProtein
            // 
            this.numericUpDownMinProtein.Location = new System.Drawing.Point(35, 22);
            this.numericUpDownMinProtein.Name = "numericUpDownMinProtein";
            this.numericUpDownMinProtein.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownMinProtein.TabIndex = 8;
            this.numericUpDownMinProtein.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelMinProtein
            // 
            this.labelMinProtein.AutoSize = true;
            this.labelMinProtein.Location = new System.Drawing.Point(6, 24);
            this.labelMinProtein.Name = "labelMinProtein";
            this.labelMinProtein.Size = new System.Drawing.Size(27, 13);
            this.labelMinProtein.TabIndex = 9;
            this.labelMinProtein.Text = "Min:";
            // 
            // labelMaxProtein
            // 
            this.labelMaxProtein.AutoSize = true;
            this.labelMaxProtein.Location = new System.Drawing.Point(136, 24);
            this.labelMaxProtein.Name = "labelMaxProtein";
            this.labelMaxProtein.Size = new System.Drawing.Size(30, 13);
            this.labelMaxProtein.TabIndex = 10;
            this.labelMaxProtein.Text = "Max:";
            // 
            // numericUpDownMaxProtein
            // 
            this.numericUpDownMaxProtein.Location = new System.Drawing.Point(170, 22);
            this.numericUpDownMaxProtein.Name = "numericUpDownMaxProtein";
            this.numericUpDownMaxProtein.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownMaxProtein.TabIndex = 11;
            this.numericUpDownMaxProtein.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Protein:";
            // 
            // checkBoxProtein
            // 
            this.checkBoxProtein.AutoSize = true;
            this.checkBoxProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProtein.Location = new System.Drawing.Point(21, 235);
            this.checkBoxProtein.Name = "checkBoxProtein";
            this.checkBoxProtein.Size = new System.Drawing.Size(72, 20);
            this.checkBoxProtein.TabIndex = 27;
            this.checkBoxProtein.Text = "Protein:";
            this.checkBoxProtein.UseVisualStyleBackColor = true;
            // 
            // groupBoxCarbs
            // 
            this.groupBoxCarbs.Controls.Add(this.labelMinCarbs);
            this.groupBoxCarbs.Controls.Add(this.numericUpDownMinCarbs);
            this.groupBoxCarbs.Controls.Add(this.labelMaxCarbs);
            this.groupBoxCarbs.Controls.Add(this.numericUpDownMaxCarbs);
            this.groupBoxCarbs.Enabled = false;
            this.groupBoxCarbs.Location = new System.Drawing.Point(21, 171);
            this.groupBoxCarbs.Name = "groupBoxCarbs";
            this.groupBoxCarbs.Size = new System.Drawing.Size(278, 61);
            this.groupBoxCarbs.TabIndex = 25;
            this.groupBoxCarbs.TabStop = false;
            // 
            // labelMinCarbs
            // 
            this.labelMinCarbs.AutoSize = true;
            this.labelMinCarbs.Location = new System.Drawing.Point(6, 25);
            this.labelMinCarbs.Name = "labelMinCarbs";
            this.labelMinCarbs.Size = new System.Drawing.Size(27, 13);
            this.labelMinCarbs.TabIndex = 4;
            this.labelMinCarbs.Text = "Min:";
            // 
            // numericUpDownMinCarbs
            // 
            this.numericUpDownMinCarbs.Location = new System.Drawing.Point(35, 23);
            this.numericUpDownMinCarbs.Name = "numericUpDownMinCarbs";
            this.numericUpDownMinCarbs.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownMinCarbs.TabIndex = 2;
            this.numericUpDownMinCarbs.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelMaxCarbs
            // 
            this.labelMaxCarbs.AutoSize = true;
            this.labelMaxCarbs.Location = new System.Drawing.Point(136, 25);
            this.labelMaxCarbs.Name = "labelMaxCarbs";
            this.labelMaxCarbs.Size = new System.Drawing.Size(30, 13);
            this.labelMaxCarbs.TabIndex = 5;
            this.labelMaxCarbs.Text = "Max:";
            // 
            // numericUpDownMaxCarbs
            // 
            this.numericUpDownMaxCarbs.Location = new System.Drawing.Point(170, 23);
            this.numericUpDownMaxCarbs.Name = "numericUpDownMaxCarbs";
            this.numericUpDownMaxCarbs.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownMaxCarbs.TabIndex = 6;
            this.numericUpDownMaxCarbs.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Protein:";
            // 
            // checkBoxCarbs
            // 
            this.checkBoxCarbs.AutoSize = true;
            this.checkBoxCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarbs.Location = new System.Drawing.Point(21, 151);
            this.checkBoxCarbs.Name = "checkBoxCarbs";
            this.checkBoxCarbs.Size = new System.Drawing.Size(66, 20);
            this.checkBoxCarbs.TabIndex = 24;
            this.checkBoxCarbs.Text = "Carbs:";
            this.checkBoxCarbs.UseVisualStyleBackColor = true;
            // 
            // comboBoxCuisine
            // 
            this.comboBoxCuisine.DisplayMember = "(none)";
            this.comboBoxCuisine.FormattingEnabled = true;
            this.comboBoxCuisine.Items.AddRange(new object[] {
            "american",
            "italian",
            "chinese",
            "mexican",
            "french",
            "mediterranean",
            "spanish"});
            this.comboBoxCuisine.Location = new System.Drawing.Point(21, 118);
            this.comboBoxCuisine.Name = "comboBoxCuisine";
            this.comboBoxCuisine.Size = new System.Drawing.Size(278, 21);
            this.comboBoxCuisine.TabIndex = 23;
            // 
            // labelCuisine
            // 
            this.labelCuisine.AutoSize = true;
            this.labelCuisine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuisine.Location = new System.Drawing.Point(18, 87);
            this.labelCuisine.Name = "labelCuisine";
            this.labelCuisine.Size = new System.Drawing.Size(55, 16);
            this.labelCuisine.TabIndex = 22;
            this.labelCuisine.Text = "Cuisine:";
            // 
            // labelProtein
            // 
            this.labelProtein.AutoSize = true;
            this.labelProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProtein.Location = new System.Drawing.Point(21, 216);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(53, 16);
            this.labelProtein.TabIndex = 7;
            this.labelProtein.Text = "Protein:";
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Location = new System.Drawing.Point(21, 47);
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(278, 20);
            this.textBoxIngredients.TabIndex = 1;
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngredients.Location = new System.Drawing.Point(18, 19);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(77, 16);
            this.labelIngredients.TabIndex = 0;
            this.labelIngredients.Text = "Ingredients:";
            // 
            // recipeNumericUpDownSearch
            // 
            this.recipeNumericUpDownSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNumericUpDownSearch.Location = new System.Drawing.Point(522, 43);
            this.recipeNumericUpDownSearch.Margin = new System.Windows.Forms.Padding(2);
            this.recipeNumericUpDownSearch.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.recipeNumericUpDownSearch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recipeNumericUpDownSearch.Name = "recipeNumericUpDownSearch";
            this.recipeNumericUpDownSearch.Size = new System.Drawing.Size(40, 24);
            this.recipeNumericUpDownSearch.TabIndex = 4;
            this.recipeNumericUpDownSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recipeNumericUpDownSearch.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // flowLayoutPanelListItems
            // 
            this.flowLayoutPanelListItems.AutoScroll = true;
            this.flowLayoutPanelListItems.Location = new System.Drawing.Point(27, 87);
            this.flowLayoutPanelListItems.Name = "flowLayoutPanelListItems";
            this.flowLayoutPanelListItems.Size = new System.Drawing.Size(609, 460);
            this.flowLayoutPanelListItems.TabIndex = 3;
            // 
            // recipeSearchButton
            // 
            this.recipeSearchButton.Location = new System.Drawing.Point(567, 42);
            this.recipeSearchButton.Name = "recipeSearchButton";
            this.recipeSearchButton.Size = new System.Drawing.Size(69, 24);
            this.recipeSearchButton.TabIndex = 1;
            this.recipeSearchButton.Text = "Search";
            this.recipeSearchButton.UseVisualStyleBackColor = true;
            // 
            // recipeTextBoxSearch
            // 
            this.recipeTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeTextBoxSearch.Location = new System.Drawing.Point(27, 43);
            this.recipeTextBoxSearch.Name = "recipeTextBoxSearch";
            this.recipeTextBoxSearch.Size = new System.Drawing.Size(491, 24);
            this.recipeTextBoxSearch.TabIndex = 0;
            // 
            // tabPageMealPlan
            // 
            this.tabPageMealPlan.Controls.Add(this.buttonGenerateMealPlan);
            this.tabPageMealPlan.Controls.Add(this.flowLayoutPanelMealPlan);
            this.tabPageMealPlan.Controls.Add(this.comboBoxDiet);
            this.tabPageMealPlan.Controls.Add(this.textBoxExcludeIng);
            this.tabPageMealPlan.Controls.Add(this.labelExcludeIng);
            this.tabPageMealPlan.Controls.Add(this.labelDiet);
            this.tabPageMealPlan.Controls.Add(this.textBoxCalories);
            this.tabPageMealPlan.Controls.Add(this.labelCalories);
            this.tabPageMealPlan.Controls.Add(this.labelMealPlan);
            this.tabPageMealPlan.Location = new System.Drawing.Point(4, 22);
            this.tabPageMealPlan.Name = "tabPageMealPlan";
            this.tabPageMealPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMealPlan.Size = new System.Drawing.Size(1011, 592);
            this.tabPageMealPlan.TabIndex = 1;
            this.tabPageMealPlan.Text = "Meal Plan";
            this.tabPageMealPlan.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateMealPlan
            // 
            this.buttonGenerateMealPlan.Location = new System.Drawing.Point(470, 164);
            this.buttonGenerateMealPlan.Name = "buttonGenerateMealPlan";
            this.buttonGenerateMealPlan.Size = new System.Drawing.Size(92, 26);
            this.buttonGenerateMealPlan.TabIndex = 11;
            this.buttonGenerateMealPlan.Text = "Generate";
            this.buttonGenerateMealPlan.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMealPlan
            // 
            this.flowLayoutPanelMealPlan.AutoScroll = true;
            this.flowLayoutPanelMealPlan.Location = new System.Drawing.Point(53, 228);
            this.flowLayoutPanelMealPlan.Name = "flowLayoutPanelMealPlan";
            this.flowLayoutPanelMealPlan.Size = new System.Drawing.Size(912, 323);
            this.flowLayoutPanelMealPlan.TabIndex = 10;
            // 
            // comboBoxDiet
            // 
            this.comboBoxDiet.FormattingEnabled = true;
            this.comboBoxDiet.Items.AddRange(new object[] {
            "Gluten Free",
            "Vegetarian",
            "Lacto-Vegetarian",
            "Ovo-Vegetarian",
            "Vegan",
            "Pescetarian"});
            this.comboBoxDiet.Location = new System.Drawing.Point(470, 95);
            this.comboBoxDiet.Name = "comboBoxDiet";
            this.comboBoxDiet.Size = new System.Drawing.Size(123, 21);
            this.comboBoxDiet.TabIndex = 9;
            // 
            // textBoxExcludeIng
            // 
            this.textBoxExcludeIng.Location = new System.Drawing.Point(470, 129);
            this.textBoxExcludeIng.Name = "textBoxExcludeIng";
            this.textBoxExcludeIng.Size = new System.Drawing.Size(201, 20);
            this.textBoxExcludeIng.TabIndex = 8;
            // 
            // labelExcludeIng
            // 
            this.labelExcludeIng.AutoSize = true;
            this.labelExcludeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExcludeIng.Location = new System.Drawing.Point(397, 131);
            this.labelExcludeIng.Name = "labelExcludeIng";
            this.labelExcludeIng.Size = new System.Drawing.Size(64, 18);
            this.labelExcludeIng.TabIndex = 7;
            this.labelExcludeIng.Text = "Exclude:";
            // 
            // labelDiet
            // 
            this.labelDiet.AutoSize = true;
            this.labelDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiet.Location = new System.Drawing.Point(397, 98);
            this.labelDiet.Name = "labelDiet";
            this.labelDiet.Size = new System.Drawing.Size(38, 18);
            this.labelDiet.TabIndex = 6;
            this.labelDiet.Text = "Diet:";
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(470, 66);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.Size = new System.Drawing.Size(123, 20);
            this.textBoxCalories.TabIndex = 5;
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalories.Location = new System.Drawing.Point(397, 66);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(67, 18);
            this.labelCalories.TabIndex = 4;
            this.labelCalories.Text = "Calories:";
            // 
            // labelMealPlan
            // 
            this.labelMealPlan.AutoSize = true;
            this.labelMealPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMealPlan.Location = new System.Drawing.Point(466, 32);
            this.labelMealPlan.Name = "labelMealPlan";
            this.labelMealPlan.Size = new System.Drawing.Size(87, 20);
            this.labelMealPlan.TabIndex = 1;
            this.labelMealPlan.Text = "Meal Plan";
            // 
            // FormMealApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 655);
            this.Controls.Add(this.tabControlSearch);
            this.Name = "FormMealApp";
            this.Text = "Meal Application";
            this.Load += new System.EventHandler(this.FormMealApp_Load);
            this.tabControlSearch.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxCalories.ResumeLayout(false);
            this.groupBoxCalories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCalories)).EndInit();
            this.groupBoxFat.ResumeLayout(false);
            this.groupBoxFat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFat)).EndInit();
            this.groupBoxProtein.ResumeLayout(false);
            this.groupBoxProtein.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxProtein)).EndInit();
            this.groupBoxCarbs.ResumeLayout(false);
            this.groupBoxCarbs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeNumericUpDownSearch)).EndInit();
            this.tabPageMealPlan.ResumeLayout(false);
            this.tabPageMealPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSearch;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Button recipeSearchButton;
        private System.Windows.Forms.TextBox recipeTextBoxSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxFat;
        private System.Windows.Forms.Label labelMaxFat;
        private System.Windows.Forms.Label labelMinFat;
        private System.Windows.Forms.NumericUpDown numericUpDownMinFat;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCalories;
        private System.Windows.Forms.Label labelMaxCalories;
        private System.Windows.Forms.Label labelMinCalories;
        private System.Windows.Forms.NumericUpDown numericUpDownMinCalories;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxProtein;
        private System.Windows.Forms.Label labelMaxProtein;
        private System.Windows.Forms.Label labelMinProtein;
        private System.Windows.Forms.NumericUpDown numericUpDownMinProtein;
        private System.Windows.Forms.Label labelProtein;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCarbs;
        private System.Windows.Forms.Label labelMaxCarbs;
        private System.Windows.Forms.Label labelMinCarbs;
        private System.Windows.Forms.NumericUpDown numericUpDownMinCarbs;
        private System.Windows.Forms.ComboBox comboBoxCuisine;
        private System.Windows.Forms.Label labelCuisine;
        private System.Windows.Forms.GroupBox groupBoxCarbs;
        private System.Windows.Forms.CheckBox checkBoxCarbs;
        private System.Windows.Forms.GroupBox groupBoxFat;
        private System.Windows.Forms.CheckBox checkBoxFat;
        private System.Windows.Forms.GroupBox groupBoxProtein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxProtein;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxCalories;
        private System.Windows.Forms.CheckBox checkBoxCalories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListItems;
        private System.Windows.Forms.NumericUpDown recipeNumericUpDownSearch;
        private System.Windows.Forms.TabPage tabPageMealPlan;
        private System.Windows.Forms.ComboBox comboBoxDiet;
        private System.Windows.Forms.TextBox textBoxExcludeIng;
        private System.Windows.Forms.Label labelExcludeIng;
        private System.Windows.Forms.Label labelDiet;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelMealPlan;
        private System.Windows.Forms.Button buttonGenerateMealPlan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMealPlan;
    }
}

