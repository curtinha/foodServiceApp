namespace foodServiceApp
{
    partial class DisplayWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayWindow));
            this.lbl_viewWindow = new System.Windows.Forms.Label();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_viewFoods = new System.Windows.Forms.Button();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_viewWindow
            // 
            this.lbl_viewWindow.AutoSize = true;
            this.lbl_viewWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_viewWindow.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_viewWindow.Location = new System.Drawing.Point(133, 9);
            this.lbl_viewWindow.Name = "lbl_viewWindow";
            this.lbl_viewWindow.Size = new System.Drawing.Size(540, 56);
            this.lbl_viewWindow.TabIndex = 0;
            this.lbl_viewWindow.Text = "Food Currently Added";
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_exp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_exp.Location = new System.Drawing.Point(51, 116);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(198, 23);
            this.lbl_exp.TabIndex = 1;
            this.lbl_exp.Text = "View Foods Expiring:";
            this.lbl_exp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_category.Location = new System.Drawing.Point(51, 211);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(198, 23);
            this.lbl_category.TabIndex = 2;
            this.lbl_category.Text = "View Foods in Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(255, 213);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(458, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 167);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_viewFoods
            // 
            this.btn_viewFoods.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_viewFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewFoods.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewFoods.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewFoods.Location = new System.Drawing.Point(255, 337);
            this.btn_viewFoods.Name = "btn_viewFoods";
            this.btn_viewFoods.Size = new System.Drawing.Size(154, 46);
            this.btn_viewFoods.TabIndex = 7;
            this.btn_viewFoods.Text = "View All Foods ";
            this.btn_viewFoods.UseVisualStyleBackColor = false;
            this.btn_viewFoods.Click += new System.EventHandler(this.btn_viewFoods_Click);
            // 
            // btn_addFood
            // 
            this.btn_addFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFood.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addFood.Location = new System.Drawing.Point(415, 337);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(154, 46);
            this.btn_addFood.TabIndex = 8;
            this.btn_addFood.Text = "Add Food ";
            this.btn_addFood.UseVisualStyleBackColor = true;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // DisplayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addFood);
            this.Controls.Add(this.btn_viewFoods);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_exp);
            this.Controls.Add(this.lbl_viewWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_viewWindow;
        private System.Windows.Forms.Label lbl_exp;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_viewFoods;
        private System.Windows.Forms.Button btn_addFood;
    }
}