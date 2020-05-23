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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.numericUpDownMinCarbs = new System.Windows.Forms.NumericUpDown();
            this.labelMinCarbs = new System.Windows.Forms.Label();
            this.labelMaxCarbs = new System.Windows.Forms.Label();
            this.numericUpDownMaxCarbs = new System.Windows.Forms.NumericUpDown();
            this.labelProtein = new System.Windows.Forms.Label();
            this.numericUpDownMaxProtein = new System.Windows.Forms.NumericUpDown();
            this.labelMaxProtein = new System.Windows.Forms.Label();
            this.labelMinProtein = new System.Windows.Forms.Label();
            this.numericUpDownMinProtein = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxCalories = new System.Windows.Forms.NumericUpDown();
            this.labelMaxCalories = new System.Windows.Forms.Label();
            this.labelMinCalories = new System.Windows.Forms.Label();
            this.numericUpDownMinCalories = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxFat = new System.Windows.Forms.NumericUpDown();
            this.labelMaxFat = new System.Windows.Forms.Label();
            this.labelMinFat = new System.Windows.Forms.Label();
            this.numericUpDownMinFat = new System.Windows.Forms.NumericUpDown();
            this.labelCuisine = new System.Windows.Forms.Label();
            this.comboBoxCuisine = new System.Windows.Forms.ComboBox();
            this.checkBoxCarbs = new System.Windows.Forms.CheckBox();
            this.groupBoxCarbs = new System.Windows.Forms.GroupBox();
            this.groupBoxProtein = new System.Windows.Forms.GroupBox();
            this.checkBoxProtein = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxFat = new System.Windows.Forms.GroupBox();
            this.checkBoxFat = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxCalories = new System.Windows.Forms.GroupBox();
            this.checkBoxCalories = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlSearch.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFat)).BeginInit();
            this.groupBoxCarbs.SuspendLayout();
            this.groupBoxProtein.SuspendLayout();
            this.groupBoxFat.SuspendLayout();
            this.groupBoxCalories.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Controls.Add(this.tabPageSearch);
            this.tabControlSearch.Location = new System.Drawing.Point(39, 34);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(1019, 596);
            this.tabControlSearch.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.splitContainer1);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1011, 570);
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
            this.splitContainer1.Panel2.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Size = new System.Drawing.Size(1005, 564);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(63, 60);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(459, 24);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(544, 60);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(69, 24);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
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
            // textBoxIngredients
            // 
            this.textBoxIngredients.Location = new System.Drawing.Point(21, 47);
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(278, 20);
            this.textBoxIngredients.TabIndex = 1;
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
            // labelMinCarbs
            // 
            this.labelMinCarbs.AutoSize = true;
            this.labelMinCarbs.Location = new System.Drawing.Point(6, 25);
            this.labelMinCarbs.Name = "labelMinCarbs";
            this.labelMinCarbs.Size = new System.Drawing.Size(27, 13);
            this.labelMinCarbs.TabIndex = 4;
            this.labelMinCarbs.Text = "Min:";
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
            // labelMaxProtein
            // 
            this.labelMaxProtein.AutoSize = true;
            this.labelMaxProtein.Location = new System.Drawing.Point(136, 24);
            this.labelMaxProtein.Name = "labelMaxProtein";
            this.labelMaxProtein.Size = new System.Drawing.Size(30, 13);
            this.labelMaxProtein.TabIndex = 10;
            this.labelMaxProtein.Text = "Max:";
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
            // labelMaxCalories
            // 
            this.labelMaxCalories.AutoSize = true;
            this.labelMaxCalories.Location = new System.Drawing.Point(136, 24);
            this.labelMaxCalories.Name = "labelMaxCalories";
            this.labelMaxCalories.Size = new System.Drawing.Size(30, 13);
            this.labelMaxCalories.TabIndex = 15;
            this.labelMaxCalories.Text = "Max:";
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
            // labelMaxFat
            // 
            this.labelMaxFat.AutoSize = true;
            this.labelMaxFat.Location = new System.Drawing.Point(136, 24);
            this.labelMaxFat.Name = "labelMaxFat";
            this.labelMaxFat.Size = new System.Drawing.Size(30, 13);
            this.labelMaxFat.TabIndex = 20;
            this.labelMaxFat.Text = "Max:";
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
            // FormMealApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 650);
            this.Controls.Add(this.tabControlSearch);
            this.Name = "FormMealApp";
            this.Text = "Meal Application";
            this.tabControlSearch.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFat)).EndInit();
            this.groupBoxCarbs.ResumeLayout(false);
            this.groupBoxCarbs.PerformLayout();
            this.groupBoxProtein.ResumeLayout(false);
            this.groupBoxProtein.PerformLayout();
            this.groupBoxFat.ResumeLayout(false);
            this.groupBoxFat.PerformLayout();
            this.groupBoxCalories.ResumeLayout(false);
            this.groupBoxCalories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSearch;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
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
    }
}

