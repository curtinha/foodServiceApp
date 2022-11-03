namespace foodServiceApp
{
    partial class addFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFood));
            this.lbl_addFood = new System.Windows.Forms.Label();
            this.dtp_addFood = new System.Windows.Forms.DateTimePicker();
            this.lbl_datemade = new System.Windows.Forms.Label();
            this.txb_foodName = new System.Windows.Forms.TextBox();
            this.lbl_foodname = new System.Windows.Forms.Label();
            this.btn_AddWindow = new System.Windows.Forms.Button();
            this.lbl_foodType = new System.Windows.Forms.Label();
            this.btn_viewWindow = new System.Windows.Forms.Button();
            this.cbx_foodType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_addFood
            // 
            this.lbl_addFood.AutoSize = true;
            this.lbl_addFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_addFood.Location = new System.Drawing.Point(225, 53);
            this.lbl_addFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addFood.Name = "lbl_addFood";
            this.lbl_addFood.Size = new System.Drawing.Size(600, 69);
            this.lbl_addFood.TabIndex = 0;
            this.lbl_addFood.Text = "Add Food to Window";
            // 
            // dtp_addFood
            // 
            this.dtp_addFood.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_addFood.CalendarTrailingForeColor = System.Drawing.Color.DodgerBlue;
            this.dtp_addFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_addFood.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_addFood.Location = new System.Drawing.Point(489, 277);
            this.dtp_addFood.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_addFood.Name = "dtp_addFood";
            this.dtp_addFood.Size = new System.Drawing.Size(265, 30);
            this.dtp_addFood.TabIndex = 1;
            // 
            // lbl_datemade
            // 
            this.lbl_datemade.AutoSize = true;
            this.lbl_datemade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datemade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_datemade.Location = new System.Drawing.Point(313, 279);
            this.lbl_datemade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datemade.Name = "lbl_datemade";
            this.lbl_datemade.Size = new System.Drawing.Size(155, 31);
            this.lbl_datemade.TabIndex = 2;
            this.lbl_datemade.Text = "Date Made";
            // 
            // txb_foodName
            // 
            this.txb_foodName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txb_foodName.Location = new System.Drawing.Point(489, 196);
            this.txb_foodName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_foodName.Name = "txb_foodName";
            this.txb_foodName.Size = new System.Drawing.Size(265, 22);
            this.txb_foodName.TabIndex = 3;
            // 
            // lbl_foodname
            // 
            this.lbl_foodname.AutoSize = true;
            this.lbl_foodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_foodname.Location = new System.Drawing.Point(313, 196);
            this.lbl_foodname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_foodname.Name = "lbl_foodname";
            this.lbl_foodname.Size = new System.Drawing.Size(164, 31);
            this.lbl_foodname.TabIndex = 4;
            this.lbl_foodname.Text = "Food Name";
            // 
            // btn_AddWindow
            // 
            this.btn_AddWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddWindow.Location = new System.Drawing.Point(325, 385);
            this.btn_AddWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddWindow.Name = "btn_AddWindow";
            this.btn_AddWindow.Size = new System.Drawing.Size(176, 28);
            this.btn_AddWindow.TabIndex = 6;
            this.btn_AddWindow.Text = "Add to window";
            this.btn_AddWindow.UseVisualStyleBackColor = false;
            this.btn_AddWindow.Click += new System.EventHandler(this.btn_addWindow_Click);
            // 
            // lbl_foodType
            // 
            this.lbl_foodType.AutoSize = true;
            this.lbl_foodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_foodType.Location = new System.Drawing.Point(313, 234);
            this.lbl_foodType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_foodType.Name = "lbl_foodType";
            this.lbl_foodType.Size = new System.Drawing.Size(153, 31);
            this.lbl_foodType.TabIndex = 8;
            this.lbl_foodType.Text = "Food Type";
            // 
            // btn_viewWindow
            // 
            this.btn_viewWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_viewWindow.Enabled = false;
            this.btn_viewWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewWindow.Location = new System.Drawing.Point(587, 385);
            this.btn_viewWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btn_viewWindow.Name = "btn_viewWindow";
            this.btn_viewWindow.Size = new System.Drawing.Size(176, 28);
            this.btn_viewWindow.TabIndex = 9;
            this.btn_viewWindow.Text = "View Window ";
            this.btn_viewWindow.UseVisualStyleBackColor = false;
            this.btn_viewWindow.Click += new System.EventHandler(this.btn_viewWindow_Click);
            // 
            // cbx_foodType
            // 
            this.cbx_foodType.AllowDrop = true;
            this.cbx_foodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_foodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_foodType.FormattingEnabled = true;
            this.cbx_foodType.Items.AddRange(new object[] {
            "Seafood",
            "Meat",
            "Chicken",
            "Salad",
            "Sandwich",
            "Platter"});
            this.cbx_foodType.Location = new System.Drawing.Point(489, 235);
            this.cbx_foodType.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_foodType.Name = "cbx_foodType";
            this.cbx_foodType.Size = new System.Drawing.Size(265, 28);
            this.cbx_foodType.TabIndex = 10;
            // 
            // addFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbx_foodType);
            this.Controls.Add(this.btn_viewWindow);
            this.Controls.Add(this.lbl_foodType);
            this.Controls.Add(this.btn_AddWindow);
            this.Controls.Add(this.lbl_foodname);
            this.Controls.Add(this.txb_foodName);
            this.Controls.Add(this.lbl_datemade);
            this.Controls.Add(this.dtp_addFood);
            this.Controls.Add(this.lbl_addFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "addFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Food Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    
        private System.Windows.Forms.Label lbl_addFood;
        private System.Windows.Forms.Label lbl_foodname;
        private System.Windows.Forms.TextBox txb_foodName;
        private System.Windows.Forms.Label lbl_datemade;
        private System.Windows.Forms.DateTimePicker dtp_addFood;
        private System.Windows.Forms.Button btn_AddWindow;
        private System.Windows.Forms.Button btn_viewWindow;
        private System.Windows.Forms.Label lbl_foodType;
        private System.Windows.Forms.ComboBox cbx_foodType;
    }
}