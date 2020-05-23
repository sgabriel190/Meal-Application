namespace Meal_Application
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelListItemTitle = new System.Windows.Forms.Label();
            this.panelPictureListItem = new System.Windows.Forms.Panel();
            this.pictureBoxListItem = new System.Windows.Forms.PictureBox();
            this.labelListItemInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPictureListItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListItemTitle
            // 
            this.labelListItemTitle.AutoSize = true;
            this.labelListItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListItemTitle.Location = new System.Drawing.Point(157, 18);
            this.labelListItemTitle.Name = "labelListItemTitle";
            this.labelListItemTitle.Size = new System.Drawing.Size(35, 18);
            this.labelListItemTitle.TabIndex = 1;
            this.labelListItemTitle.Text = "Title";
            // 
            // panelPictureListItem
            // 
            this.panelPictureListItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPictureListItem.Controls.Add(this.pictureBoxListItem);
            this.panelPictureListItem.Location = new System.Drawing.Point(0, 0);
            this.panelPictureListItem.Name = "panelPictureListItem";
            this.panelPictureListItem.Size = new System.Drawing.Size(138, 103);
            this.panelPictureListItem.TabIndex = 4;
            // 
            // pictureBoxListItem
            // 
            this.pictureBoxListItem.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxListItem.Name = "pictureBoxListItem";
            this.pictureBoxListItem.Size = new System.Drawing.Size(132, 90);
            this.pictureBoxListItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxListItem.TabIndex = 0;
            this.pictureBoxListItem.TabStop = false;
            // 
            // labelListItemInfo
            // 
            this.labelListItemInfo.AutoSize = true;
            this.labelListItemInfo.Location = new System.Drawing.Point(157, 45);
            this.labelListItemInfo.Name = "labelListItemInfo";
            this.labelListItemInfo.Size = new System.Drawing.Size(25, 13);
            this.labelListItemInfo.TabIndex = 5;
            this.labelListItemInfo.Text = "Info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 10);
            this.panel1.TabIndex = 3;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelListItemInfo);
            this.Controls.Add(this.panelPictureListItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelListItemTitle);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(570, 97);
            this.panelPictureListItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListItemTitle;
        private System.Windows.Forms.Panel panelPictureListItem;
        private System.Windows.Forms.PictureBox pictureBoxListItem;
        private System.Windows.Forms.Label labelListItemInfo;
        private System.Windows.Forms.Panel panel1;
    }
}
