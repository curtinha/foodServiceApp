namespace foodServiceApp
{
    partial class displayWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(displayWindow));
            this.lbl_viewWindow = new System.Windows.Forms.Label();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cbx_viewExp = new System.Windows.Forms.ComboBox();
            this.cbx_viewCategory = new System.Windows.Forms.ComboBox();
            this.btn_viewFoods = new System.Windows.Forms.Button();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.lbx_window = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_viewWindow
            // 
            this.lbl_viewWindow.AutoSize = true;
            this.lbl_viewWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_viewWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_viewWindow.Location = new System.Drawing.Point(133, 9);
            this.lbl_viewWindow.Name = "lbl_viewWindow";
            this.lbl_viewWindow.Size = new System.Drawing.Size(515, 55);
            this.lbl_viewWindow.TabIndex = 0;
            this.lbl_viewWindow.Text = "Food Currently Added";
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_exp.Location = new System.Drawing.Point(46, 121);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(201, 20);
            this.lbl_exp.TabIndex = 1;
            this.lbl_exp.Text = "View Foods Expiring on:";
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_category.Location = new System.Drawing.Point(46, 213);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(203, 23);
            this.lbl_category.TabIndex = 2;
            this.lbl_category.Text = "View Foods in Category:";
            // 
            // cbx_viewExp
            // 
            this.cbx_viewExp.AllowDrop = true;
            this.cbx_viewExp.BackColor = System.Drawing.Color.White;
            this.cbx_viewExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_viewExp.FormattingEnabled = true;
            this.cbx_viewExp.Items.AddRange(new object[] {
            "Today",
            "In 1 Day",
            "In 2 Days",
            "In 3 Days",
            "In 4 Days"});
            this.cbx_viewExp.Location = new System.Drawing.Point(255, 120);
            this.cbx_viewExp.Name = "cbx_viewExp";
            this.cbx_viewExp.Size = new System.Drawing.Size(121, 21);
            this.cbx_viewExp.TabIndex = 4;
            this.cbx_viewExp.SelectedIndexChanged += new System.EventHandler(this.cbx_viewFood_SelectedIndexChanged);
            // 
            // cbx_viewCategory
            // 
            this.cbx_viewCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_viewCategory.FormattingEnabled = true;
            this.cbx_viewCategory.Items.AddRange(new object[] {
            "Seafood",
            "Meat",
            "Chicken",
            "Salad",
            "Sandwich",
            "Platter"});
            this.cbx_viewCategory.Location = new System.Drawing.Point(255, 213);
            this.cbx_viewCategory.Name = "cbx_viewCategory";
            this.cbx_viewCategory.Size = new System.Drawing.Size(121, 21);
            this.cbx_viewCategory.TabIndex = 5;
            // 
            // btn_viewFoods
            // 
            this.btn_viewFoods.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_viewFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewFoods.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewFoods.Location = new System.Drawing.Point(255, 337);
            this.btn_viewFoods.Name = "btn_viewFoods";
            this.btn_viewFoods.Size = new System.Drawing.Size(154, 46);
            this.btn_viewFoods.TabIndex = 7;
            this.btn_viewFoods.Text = "View All";
            this.btn_viewFoods.UseVisualStyleBackColor = false;
            this.btn_viewFoods.Click += new System.EventHandler(this.btn_viewFoods_Click);
            // 
            // btn_addFood
            // 
            this.btn_addFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addFood.Location = new System.Drawing.Point(415, 337);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(154, 46);
            this.btn_addFood.TabIndex = 8;
            this.btn_addFood.Text = "Add Food ";
            this.btn_addFood.UseVisualStyleBackColor = true;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // lbx_window
            // 
            this.lbx_window.FormattingEnabled = true;
            this.lbx_window.Location = new System.Drawing.Point(461, 94);
            this.lbx_window.Name = "lbx_window";
            this.lbx_window.Size = new System.Drawing.Size(272, 173);
            this.lbx_window.TabIndex = 10;
            // 
            // displayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbx_window);
            this.Controls.Add(this.btn_addFood);
            this.Controls.Add(this.btn_viewFoods);
            this.Controls.Add(this.cbx_viewCategory);
            this.Controls.Add(this.cbx_viewExp);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_exp);
            this.Controls.Add(this.lbl_viewWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "displayWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Foods in Display";
            this.Load += new System.EventHandler(this.displayWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_viewWindow;
        private System.Windows.Forms.Label lbl_exp;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cbx_viewExp;
        private System.Windows.Forms.ComboBox cbx_viewCategory;
        private System.Windows.Forms.Button btn_viewFoods;
        private System.Windows.Forms.Button btn_addFood;
        private System.Windows.Forms.ListBox lbx_window;
    }
}