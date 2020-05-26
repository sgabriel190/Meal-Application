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
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.buttonChangeApiKey = new System.Windows.Forms.Button();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.groupBoxNutrients = new System.Windows.Forms.GroupBox();
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
            this.labelProtein = new System.Windows.Forms.Label();
            this.radioButtonNutrients = new System.Windows.Forms.RadioButton();
            this.radioButtonIngredients = new System.Windows.Forms.RadioButton();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResultsNumber = new System.Windows.Forms.Label();
            this.recipeNumericUpDownSearch = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelListItems = new System.Windows.Forms.FlowLayoutPanel();
            this.recipeSearchButton = new System.Windows.Forms.Button();
            this.tabPageMealPlan = new System.Windows.Forms.TabPage();
            this.buttonApiKeyTab2 = new System.Windows.Forms.Button();
            this.textBoxApiKeyTab2 = new System.Windows.Forms.TextBox();
            this.labelApiKeyTab2 = new System.Windows.Forms.Label();
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
            this.groupBoxNutrients.SuspendLayout();
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
            this.tabPageSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.splitContainer1.Panel1.Controls.Add(this.textBoxApiKey);
            this.splitContainer1.Panel1.Controls.Add(this.buttonChangeApiKey);
            this.splitContainer1.Panel1.Controls.Add(this.labelApiKey);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxNutrients);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonNutrients);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonIngredients);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIngredients);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.labelResultsNumber);
            this.splitContainer1.Panel2.Controls.Add(this.recipeNumericUpDownSearch);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelListItems);
            this.splitContainer1.Panel2.Controls.Add(this.recipeSearchButton);
            this.splitContainer1.Size = new System.Drawing.Size(1005, 586);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxApiKey.Location = new System.Drawing.Point(66, 35);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.Size = new System.Drawing.Size(243, 21);
            this.textBoxApiKey.TabIndex = 45;
            this.textBoxApiKey.Text = "Ex:7b137a9d00974ba4b92d25f4d51d11c6";
            // 
            // buttonChangeApiKey
            // 
            this.buttonChangeApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeApiKey.Location = new System.Drawing.Point(121, 60);
            this.buttonChangeApiKey.Name = "buttonChangeApiKey";
            this.buttonChangeApiKey.Size = new System.Drawing.Size(61, 21);
            this.buttonChangeApiKey.TabIndex = 41;
            this.buttonChangeApiKey.Text = "Change";
            this.buttonChangeApiKey.UseVisualStyleBackColor = true;
            this.buttonChangeApiKey.Click += new System.EventHandler(this.buttonChangeApiKey_Click);
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApiKey.Location = new System.Drawing.Point(10, 37);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(57, 16);
            this.labelApiKey.TabIndex = 39;
            this.labelApiKey.Text = "Api Key:";
            // 
            // groupBoxNutrients
            // 
            this.groupBoxNutrients.Controls.Add(this.groupBoxCalories);
            this.groupBoxNutrients.Controls.Add(this.checkBoxCalories);
            this.groupBoxNutrients.Controls.Add(this.groupBoxFat);
            this.groupBoxNutrients.Controls.Add(this.label5);
            this.groupBoxNutrients.Controls.Add(this.checkBoxFat);
            this.groupBoxNutrients.Controls.Add(this.groupBoxProtein);
            this.groupBoxNutrients.Controls.Add(this.label4);
            this.groupBoxNutrients.Controls.Add(this.checkBoxProtein);
            this.groupBoxNutrients.Controls.Add(this.groupBoxCarbs);
            this.groupBoxNutrients.Controls.Add(this.label3);
            this.groupBoxNutrients.Controls.Add(this.checkBoxCarbs);
            this.groupBoxNutrients.Controls.Add(this.labelProtein);
            this.groupBoxNutrients.Enabled = false;
            this.groupBoxNutrients.Location = new System.Drawing.Point(13, 178);
            this.groupBoxNutrients.Name = "groupBoxNutrients";
            this.groupBoxNutrients.Size = new System.Drawing.Size(296, 378);
            this.groupBoxNutrients.TabIndex = 37;
            this.groupBoxNutrients.TabStop = false;
            // 
            // groupBoxCalories
            // 
            this.groupBoxCalories.Controls.Add(this.numericUpDownMinCalories);
            this.groupBoxCalories.Controls.Add(this.labelMinCalories);
            this.groupBoxCalories.Controls.Add(this.labelMaxCalories);
            this.groupBoxCalories.Controls.Add(this.numericUpDownMaxCalories);
            this.groupBoxCalories.Enabled = false;
            this.groupBoxCalories.Location = new System.Drawing.Point(9, 297);
            this.groupBoxCalories.Name = "groupBoxCalories";
            this.groupBoxCalories.Size = new System.Drawing.Size(278, 61);
            this.groupBoxCalories.TabIndex = 34;
            this.groupBoxCalories.TabStop = false;
            // 
            // numericUpDownMinCalories
            // 
            this.numericUpDownMinCalories.Location = new System.Drawing.Point(35, 22);
            this.numericUpDownMinCalories.Name = "numericUpDownMinCalories";
            this.numericUpDownMinCalories.Size = new System.Drawing.Size(95, 21);
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
            this.labelMinCalories.Location = new System.Drawing.Point(0, 24);
            this.labelMinCalories.Name = "labelMinCalories";
            this.labelMinCalories.Size = new System.Drawing.Size(31, 15);
            this.labelMinCalories.TabIndex = 14;
            this.labelMinCalories.Text = "Min:";
            // 
            // labelMaxCalories
            // 
            this.labelMaxCalories.AutoSize = true;
            this.labelMaxCalories.Location = new System.Drawing.Point(136, 24);
            this.labelMaxCalories.Name = "labelMaxCalories";
            this.labelMaxCalories.Size = new System.Drawing.Size(34, 15);
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
            this.numericUpDownMaxCalories.Size = new System.Drawing.Size(99, 21);
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
            this.checkBoxCalories.Location = new System.Drawing.Point(9, 277);
            this.checkBoxCalories.Name = "checkBoxCalories";
            this.checkBoxCalories.Size = new System.Drawing.Size(80, 20);
            this.checkBoxCalories.TabIndex = 33;
            this.checkBoxCalories.Text = "Calories:";
            this.checkBoxCalories.UseVisualStyleBackColor = true;
            this.checkBoxCalories.CheckedChanged += new System.EventHandler(this.checkBoxCalories_CheckedChanged);
            // 
            // groupBoxFat
            // 
            this.groupBoxFat.Controls.Add(this.labelMinFat);
            this.groupBoxFat.Controls.Add(this.numericUpDownMinFat);
            this.groupBoxFat.Controls.Add(this.labelMaxFat);
            this.groupBoxFat.Controls.Add(this.numericUpDownMaxFat);
            this.groupBoxFat.Enabled = false;
            this.groupBoxFat.Location = new System.Drawing.Point(9, 210);
            this.groupBoxFat.Name = "groupBoxFat";
            this.groupBoxFat.Size = new System.Drawing.Size(278, 61);
            this.groupBoxFat.TabIndex = 31;
            this.groupBoxFat.TabStop = false;
            // 
            // labelMinFat
            // 
            this.labelMinFat.AutoSize = true;
            this.labelMinFat.Location = new System.Drawing.Point(0, 24);
            this.labelMinFat.Name = "labelMinFat";
            this.labelMinFat.Size = new System.Drawing.Size(31, 15);
            this.labelMinFat.TabIndex = 19;
            this.labelMinFat.Text = "Min:";
            // 
            // numericUpDownMinFat
            // 
            this.numericUpDownMinFat.Location = new System.Drawing.Point(35, 22);
            this.numericUpDownMinFat.Name = "numericUpDownMinFat";
            this.numericUpDownMinFat.Size = new System.Drawing.Size(95, 21);
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
            this.labelMaxFat.Size = new System.Drawing.Size(34, 15);
            this.labelMaxFat.TabIndex = 20;
            this.labelMaxFat.Text = "Max:";
            // 
            // numericUpDownMaxFat
            // 
            this.numericUpDownMaxFat.Location = new System.Drawing.Point(170, 22);
            this.numericUpDownMaxFat.Name = "numericUpDownMaxFat";
            this.numericUpDownMaxFat.Size = new System.Drawing.Size(99, 21);
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
            this.label5.Location = new System.Drawing.Point(9, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Protein:";
            // 
            // checkBoxFat
            // 
            this.checkBoxFat.AutoSize = true;
            this.checkBoxFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFat.Location = new System.Drawing.Point(9, 190);
            this.checkBoxFat.Name = "checkBoxFat";
            this.checkBoxFat.Size = new System.Drawing.Size(49, 20);
            this.checkBoxFat.TabIndex = 30;
            this.checkBoxFat.Text = "Fat:";
            this.checkBoxFat.UseVisualStyleBackColor = true;
            this.checkBoxFat.CheckedChanged += new System.EventHandler(this.checkBoxFat_CheckedChanged);
            // 
            // groupBoxProtein
            // 
            this.groupBoxProtein.Controls.Add(this.numericUpDownMinProtein);
            this.groupBoxProtein.Controls.Add(this.labelMinProtein);
            this.groupBoxProtein.Controls.Add(this.labelMaxProtein);
            this.groupBoxProtein.Controls.Add(this.numericUpDownMaxProtein);
            this.groupBoxProtein.Enabled = false;
            this.groupBoxProtein.Location = new System.Drawing.Point(9, 123);
            this.groupBoxProtein.Name = "groupBoxProtein";
            this.groupBoxProtein.Size = new System.Drawing.Size(278, 61);
            this.groupBoxProtein.TabIndex = 28;
            this.groupBoxProtein.TabStop = false;
            // 
            // numericUpDownMinProtein
            // 
            this.numericUpDownMinProtein.Location = new System.Drawing.Point(35, 22);
            this.numericUpDownMinProtein.Name = "numericUpDownMinProtein";
            this.numericUpDownMinProtein.Size = new System.Drawing.Size(95, 21);
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
            this.labelMinProtein.Location = new System.Drawing.Point(-2, 24);
            this.labelMinProtein.Name = "labelMinProtein";
            this.labelMinProtein.Size = new System.Drawing.Size(31, 15);
            this.labelMinProtein.TabIndex = 9;
            this.labelMinProtein.Text = "Min:";
            // 
            // labelMaxProtein
            // 
            this.labelMaxProtein.AutoSize = true;
            this.labelMaxProtein.Location = new System.Drawing.Point(136, 24);
            this.labelMaxProtein.Name = "labelMaxProtein";
            this.labelMaxProtein.Size = new System.Drawing.Size(34, 15);
            this.labelMaxProtein.TabIndex = 10;
            this.labelMaxProtein.Text = "Max:";
            // 
            // numericUpDownMaxProtein
            // 
            this.numericUpDownMaxProtein.Location = new System.Drawing.Point(170, 22);
            this.numericUpDownMaxProtein.Name = "numericUpDownMaxProtein";
            this.numericUpDownMaxProtein.Size = new System.Drawing.Size(99, 21);
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
            this.label4.Location = new System.Drawing.Point(9, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Protein:";
            // 
            // checkBoxProtein
            // 
            this.checkBoxProtein.AutoSize = true;
            this.checkBoxProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProtein.Location = new System.Drawing.Point(9, 103);
            this.checkBoxProtein.Name = "checkBoxProtein";
            this.checkBoxProtein.Size = new System.Drawing.Size(72, 20);
            this.checkBoxProtein.TabIndex = 27;
            this.checkBoxProtein.Text = "Protein:";
            this.checkBoxProtein.UseVisualStyleBackColor = true;
            this.checkBoxProtein.CheckedChanged += new System.EventHandler(this.checkBoxProtein_CheckedChanged);
            // 
            // groupBoxCarbs
            // 
            this.groupBoxCarbs.Controls.Add(this.labelMinCarbs);
            this.groupBoxCarbs.Controls.Add(this.numericUpDownMinCarbs);
            this.groupBoxCarbs.Controls.Add(this.labelMaxCarbs);
            this.groupBoxCarbs.Controls.Add(this.numericUpDownMaxCarbs);
            this.groupBoxCarbs.Enabled = false;
            this.groupBoxCarbs.Location = new System.Drawing.Point(9, 39);
            this.groupBoxCarbs.Name = "groupBoxCarbs";
            this.groupBoxCarbs.Size = new System.Drawing.Size(278, 61);
            this.groupBoxCarbs.TabIndex = 25;
            this.groupBoxCarbs.TabStop = false;
            // 
            // labelMinCarbs
            // 
            this.labelMinCarbs.AutoSize = true;
            this.labelMinCarbs.Location = new System.Drawing.Point(0, 25);
            this.labelMinCarbs.Name = "labelMinCarbs";
            this.labelMinCarbs.Size = new System.Drawing.Size(31, 15);
            this.labelMinCarbs.TabIndex = 4;
            this.labelMinCarbs.Text = "Min:";
            // 
            // numericUpDownMinCarbs
            // 
            this.numericUpDownMinCarbs.Location = new System.Drawing.Point(35, 23);
            this.numericUpDownMinCarbs.Name = "numericUpDownMinCarbs";
            this.numericUpDownMinCarbs.Size = new System.Drawing.Size(95, 21);
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
            this.labelMaxCarbs.Size = new System.Drawing.Size(34, 15);
            this.labelMaxCarbs.TabIndex = 5;
            this.labelMaxCarbs.Text = "Max:";
            // 
            // numericUpDownMaxCarbs
            // 
            this.numericUpDownMaxCarbs.Location = new System.Drawing.Point(170, 23);
            this.numericUpDownMaxCarbs.Name = "numericUpDownMaxCarbs";
            this.numericUpDownMaxCarbs.Size = new System.Drawing.Size(99, 21);
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
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Protein:";
            // 
            // checkBoxCarbs
            // 
            this.checkBoxCarbs.AutoSize = true;
            this.checkBoxCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarbs.Location = new System.Drawing.Point(9, 19);
            this.checkBoxCarbs.Name = "checkBoxCarbs";
            this.checkBoxCarbs.Size = new System.Drawing.Size(66, 20);
            this.checkBoxCarbs.TabIndex = 24;
            this.checkBoxCarbs.Text = "Carbs:";
            this.checkBoxCarbs.UseVisualStyleBackColor = true;
            this.checkBoxCarbs.CheckedChanged += new System.EventHandler(this.checkBoxCarbs_CheckedChanged);
            // 
            // labelProtein
            // 
            this.labelProtein.AutoSize = true;
            this.labelProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProtein.Location = new System.Drawing.Point(9, 84);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(53, 16);
            this.labelProtein.TabIndex = 7;
            this.labelProtein.Text = "Protein:";
            // 
            // radioButtonNutrients
            // 
            this.radioButtonNutrients.AutoSize = true;
            this.radioButtonNutrients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNutrients.Location = new System.Drawing.Point(13, 152);
            this.radioButtonNutrients.Name = "radioButtonNutrients";
            this.radioButtonNutrients.Size = new System.Drawing.Size(78, 20);
            this.radioButtonNutrients.TabIndex = 36;
            this.radioButtonNutrients.Text = "Nutrients";
            this.radioButtonNutrients.UseVisualStyleBackColor = true;
            this.radioButtonNutrients.CheckedChanged += new System.EventHandler(this.radioButtonNutrients_CheckedChanged);
            // 
            // radioButtonIngredients
            // 
            this.radioButtonIngredients.AutoSize = true;
            this.radioButtonIngredients.Checked = true;
            this.radioButtonIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIngredients.Location = new System.Drawing.Point(13, 87);
            this.radioButtonIngredients.Name = "radioButtonIngredients";
            this.radioButtonIngredients.Size = new System.Drawing.Size(92, 20);
            this.radioButtonIngredients.TabIndex = 35;
            this.radioButtonIngredients.TabStop = true;
            this.radioButtonIngredients.Text = "Ingredients";
            this.radioButtonIngredients.UseVisualStyleBackColor = true;
            this.radioButtonIngredients.CheckedChanged += new System.EventHandler(this.radioButtonIngredients_CheckedChanged);
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Location = new System.Drawing.Point(13, 112);
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(296, 21);
            this.textBoxIngredients.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search Results";
            // 
            // labelResultsNumber
            // 
            this.labelResultsNumber.AutoSize = true;
            this.labelResultsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultsNumber.Location = new System.Drawing.Point(477, 35);
            this.labelResultsNumber.Name = "labelResultsNumber";
            this.labelResultsNumber.Size = new System.Drawing.Size(40, 26);
            this.labelResultsNumber.TabIndex = 35;
            this.labelResultsNumber.Text = "Nr of\r\nresults:";
            // 
            // recipeNumericUpDownSearch
            // 
            this.recipeNumericUpDownSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNumericUpDownSearch.Location = new System.Drawing.Point(522, 37);
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
            10,
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
            this.recipeSearchButton.Location = new System.Drawing.Point(567, 37);
            this.recipeSearchButton.Name = "recipeSearchButton";
            this.recipeSearchButton.Size = new System.Drawing.Size(69, 25);
            this.recipeSearchButton.TabIndex = 1;
            this.recipeSearchButton.Text = "Search";
            this.recipeSearchButton.UseVisualStyleBackColor = true;
            this.recipeSearchButton.Click += new System.EventHandler(this.recipeSearchButton_Click);
            // 
            // tabPageMealPlan
            // 
            this.tabPageMealPlan.Controls.Add(this.buttonApiKeyTab2);
            this.tabPageMealPlan.Controls.Add(this.textBoxApiKeyTab2);
            this.tabPageMealPlan.Controls.Add(this.labelApiKeyTab2);
            this.tabPageMealPlan.Controls.Add(this.buttonGenerateMealPlan);
            this.tabPageMealPlan.Controls.Add(this.flowLayoutPanelMealPlan);
            this.tabPageMealPlan.Controls.Add(this.comboBoxDiet);
            this.tabPageMealPlan.Controls.Add(this.textBoxExcludeIng);
            this.tabPageMealPlan.Controls.Add(this.labelExcludeIng);
            this.tabPageMealPlan.Controls.Add(this.labelDiet);
            this.tabPageMealPlan.Controls.Add(this.textBoxCalories);
            this.tabPageMealPlan.Controls.Add(this.labelCalories);
            this.tabPageMealPlan.Controls.Add(this.labelMealPlan);
            this.tabPageMealPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMealPlan.Location = new System.Drawing.Point(4, 22);
            this.tabPageMealPlan.Name = "tabPageMealPlan";
            this.tabPageMealPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMealPlan.Size = new System.Drawing.Size(1011, 592);
            this.tabPageMealPlan.TabIndex = 1;
            this.tabPageMealPlan.Text = "Meal Plan";
            this.tabPageMealPlan.UseVisualStyleBackColor = true;
            // 
            // buttonApiKeyTab2
            // 
            this.buttonApiKeyTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApiKeyTab2.Location = new System.Drawing.Point(157, 78);
            this.buttonApiKeyTab2.Name = "buttonApiKeyTab2";
            this.buttonApiKeyTab2.Size = new System.Drawing.Size(61, 21);
            this.buttonApiKeyTab2.TabIndex = 45;
            this.buttonApiKeyTab2.Text = "Change";
            this.buttonApiKeyTab2.UseVisualStyleBackColor = true;
            this.buttonApiKeyTab2.Click += new System.EventHandler(this.buttonApiKeyTab2_Click);
            // 
            // textBoxApiKeyTab2
            // 
            this.textBoxApiKeyTab2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxApiKeyTab2.Location = new System.Drawing.Point(100, 53);
            this.textBoxApiKeyTab2.Name = "textBoxApiKeyTab2";
            this.textBoxApiKeyTab2.Size = new System.Drawing.Size(245, 21);
            this.textBoxApiKeyTab2.TabIndex = 44;
            this.textBoxApiKeyTab2.Text = "Ex:7b137a9d00974ba4b92d25f4d51d11c6";
            // 
            // labelApiKeyTab2
            // 
            this.labelApiKeyTab2.AutoSize = true;
            this.labelApiKeyTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApiKeyTab2.Location = new System.Drawing.Point(46, 56);
            this.labelApiKeyTab2.Name = "labelApiKeyTab2";
            this.labelApiKeyTab2.Size = new System.Drawing.Size(57, 16);
            this.labelApiKeyTab2.TabIndex = 43;
            this.labelApiKeyTab2.Text = "Api Key:";
            // 
            // buttonGenerateMealPlan
            // 
            this.buttonGenerateMealPlan.Location = new System.Drawing.Point(558, 154);
            this.buttonGenerateMealPlan.Name = "buttonGenerateMealPlan";
            this.buttonGenerateMealPlan.Size = new System.Drawing.Size(92, 26);
            this.buttonGenerateMealPlan.TabIndex = 11;
            this.buttonGenerateMealPlan.Text = "Generate";
            this.buttonGenerateMealPlan.UseVisualStyleBackColor = true;
            this.buttonGenerateMealPlan.Click += new System.EventHandler(this.buttonGenerateMealPlan_Click);
            // 
            // flowLayoutPanelMealPlan
            // 
            this.flowLayoutPanelMealPlan.Location = new System.Drawing.Point(53, 196);
            this.flowLayoutPanelMealPlan.Name = "flowLayoutPanelMealPlan";
            this.flowLayoutPanelMealPlan.Size = new System.Drawing.Size(912, 390);
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
            this.comboBoxDiet.Location = new System.Drawing.Point(558, 85);
            this.comboBoxDiet.Name = "comboBoxDiet";
            this.comboBoxDiet.Size = new System.Drawing.Size(123, 23);
            this.comboBoxDiet.TabIndex = 9;
            // 
            // textBoxExcludeIng
            // 
            this.textBoxExcludeIng.Location = new System.Drawing.Point(558, 119);
            this.textBoxExcludeIng.Name = "textBoxExcludeIng";
            this.textBoxExcludeIng.Size = new System.Drawing.Size(201, 21);
            this.textBoxExcludeIng.TabIndex = 8;
            // 
            // labelExcludeIng
            // 
            this.labelExcludeIng.AutoSize = true;
            this.labelExcludeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExcludeIng.Location = new System.Drawing.Point(485, 121);
            this.labelExcludeIng.Name = "labelExcludeIng";
            this.labelExcludeIng.Size = new System.Drawing.Size(64, 18);
            this.labelExcludeIng.TabIndex = 7;
            this.labelExcludeIng.Text = "Exclude:";
            // 
            // labelDiet
            // 
            this.labelDiet.AutoSize = true;
            this.labelDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiet.Location = new System.Drawing.Point(485, 88);
            this.labelDiet.Name = "labelDiet";
            this.labelDiet.Size = new System.Drawing.Size(38, 18);
            this.labelDiet.TabIndex = 6;
            this.labelDiet.Text = "Diet:";
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(558, 56);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.Size = new System.Drawing.Size(123, 21);
            this.textBoxCalories.TabIndex = 5;
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalories.Location = new System.Drawing.Point(485, 56);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(67, 18);
            this.labelCalories.TabIndex = 4;
            this.labelCalories.Text = "Calories:";
            // 
            // labelMealPlan
            // 
            this.labelMealPlan.AutoSize = true;
            this.labelMealPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMealPlan.Location = new System.Drawing.Point(554, 22);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.groupBoxNutrients.ResumeLayout(false);
            this.groupBoxNutrients.PerformLayout();
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
        private System.Windows.Forms.Button recipeSearchButton;
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
        private System.Windows.Forms.Label labelResultsNumber;
        private System.Windows.Forms.GroupBox groupBoxNutrients;
        private System.Windows.Forms.RadioButton radioButtonNutrients;
        private System.Windows.Forms.RadioButton radioButtonIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelApiKey;
        private System.Windows.Forms.Button buttonChangeApiKey;
        private System.Windows.Forms.Button buttonApiKeyTab2;
        private System.Windows.Forms.TextBox textBoxApiKeyTab2;
        private System.Windows.Forms.Label labelApiKeyTab2;
        private System.Windows.Forms.TextBox textBoxApiKey;
    }
}

