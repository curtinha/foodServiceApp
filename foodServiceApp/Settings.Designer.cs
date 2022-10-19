namespace foodServiceApp
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lbl_title = new System.Windows.Forms.Label();
            this.cbx_foodName = new System.Windows.Forms.ComboBox();
            this.cbx_expDate = new System.Windows.Forms.ComboBox();
            this.lbl_food = new System.Windows.Forms.Label();
            this.lbl_expValue = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(300, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(205, 55);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "Settings";
            // 
            // cbx_foodName
            // 
            this.cbx_foodName.AllowDrop = true;
            this.cbx_foodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_foodName.FormattingEnabled = true;
            this.cbx_foodName.Items.AddRange(new object[] {
            "Seafood",
            "Meat",
            "Chicken",
            "Salad",
            "Sandwich",
            "Platter"});
            this.cbx_foodName.Location = new System.Drawing.Point(448, 129);
            this.cbx_foodName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_foodName.Name = "cbx_foodName";
            this.cbx_foodName.Size = new System.Drawing.Size(133, 21);
            this.cbx_foodName.TabIndex = 11;
            // 
            // cbx_expDate
            // 
            this.cbx_expDate.AllowDrop = true;
            this.cbx_expDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_expDate.FormattingEnabled = true;
            this.cbx_expDate.Items.AddRange(new object[] {
            "1 Day",
            "2 Days",
            "3 Days",
            "4 Days",
            "5 Days",
            "6 Days",
            "7 Days"});
            this.cbx_expDate.Location = new System.Drawing.Point(448, 237);
            this.cbx_expDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_expDate.Name = "cbx_expDate";
            this.cbx_expDate.Size = new System.Drawing.Size(133, 21);
            this.cbx_expDate.TabIndex = 12;
            // 
            // lbl_food
            // 
            this.lbl_food.AutoSize = true;
            this.lbl_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_food.Location = new System.Drawing.Point(213, 130);
            this.lbl_food.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_food.Name = "lbl_food";
            this.lbl_food.Size = new System.Drawing.Size(98, 20);
            this.lbl_food.TabIndex = 13;
            this.lbl_food.Text = "Food Type:";
     
            // 
            // lbl_expValue
            // 
            this.lbl_expValue.AutoSize = true;
            this.lbl_expValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_expValue.Location = new System.Drawing.Point(213, 238);
            this.lbl_expValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_expValue.Name = "lbl_expValue";
            this.lbl_expValue.Size = new System.Drawing.Size(195, 20);
            this.lbl_expValue.TabIndex = 14;
            this.lbl_expValue.Text = "Enter Display Duration:\r\n";
           
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.Location = new System.Drawing.Point(354, 325);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(139, 36);
            this.btn_home.TabIndex = 15;
            this.btn_home.Text = "Return Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lbl_expValue);
            this.Controls.Add(this.lbl_food);
            this.Controls.Add(this.cbx_expDate);
            this.Controls.Add(this.cbx_foodName);
            this.Controls.Add(this.lbl_title);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cbx_foodName;
        private System.Windows.Forms.ComboBox cbx_expDate;
        private System.Windows.Forms.Label lbl_food;
        private System.Windows.Forms.Label lbl_expValue;
        private System.Windows.Forms.Button btn_home;
    }
}