namespace foodServiceApp
{
    partial class AddFood
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_AddFood = new System.Windows.Forms.Label();
            this.dtp_AddFood = new System.Windows.Forms.DateTimePicker();
            this.lbl_datemade = new System.Windows.Forms.Label();
            this.txb_foodName = new System.Windows.Forms.TextBox();
            this.lbl_foodname = new System.Windows.Forms.Label();
            this.btn_AddWindow = new System.Windows.Forms.Button();
            this.lbl_foodType = new System.Windows.Forms.Label();
            this.txb_FoodType = new System.Windows.Forms.TextBox();
            this.btn_Viewwindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_AddFood
            // 
            this.lbl_AddFood.AutoSize = true;
            this.lbl_AddFood.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddFood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AddFood.Location = new System.Drawing.Point(169, 43);
            this.lbl_AddFood.Name = "lbl_AddFood";
            this.lbl_AddFood.Size = new System.Drawing.Size(510, 56);
            this.lbl_AddFood.TabIndex = 0;
            this.lbl_AddFood.Text = "Add Food to Window";
            // 
            // dtp_AddFood
            // 
            this.dtp_AddFood.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_AddFood.CalendarTrailingForeColor = System.Drawing.Color.DodgerBlue;
            this.dtp_AddFood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_AddFood.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_AddFood.Location = new System.Drawing.Point(367, 225);
            this.dtp_AddFood.Name = "dtp_AddFood";
            this.dtp_AddFood.Size = new System.Drawing.Size(200, 27);
            this.dtp_AddFood.TabIndex = 1;
            // 
            // lbl_datemade
            // 
            this.lbl_datemade.AutoSize = true;
            this.lbl_datemade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datemade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_datemade.Location = new System.Drawing.Point(235, 227);
            this.lbl_datemade.Name = "lbl_datemade";
            this.lbl_datemade.Size = new System.Drawing.Size(126, 25);
            this.lbl_datemade.TabIndex = 2;
            this.lbl_datemade.Text = "Date Made";
            this.lbl_datemade.Click += new System.EventHandler(this.lbl_datemade_Click);
            // 
            // txb_foodName
            // 
            this.txb_foodName.Location = new System.Drawing.Point(367, 159);
            this.txb_foodName.Name = "txb_foodName";
            this.txb_foodName.Size = new System.Drawing.Size(200, 20);
            this.txb_foodName.TabIndex = 3;
            // 
            // lbl_foodname
            // 
            this.lbl_foodname.AutoSize = true;
            this.lbl_foodname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_foodname.Location = new System.Drawing.Point(235, 159);
            this.lbl_foodname.Name = "lbl_foodname";
            this.lbl_foodname.Size = new System.Drawing.Size(131, 25);
            this.lbl_foodname.TabIndex = 4;
            this.lbl_foodname.Text = "Food Name";
            // 
            // btn_AddWindow
            // 
            this.btn_AddWindow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddWindow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddWindow.Location = new System.Drawing.Point(244, 313);
            this.btn_AddWindow.Name = "btn_AddWindow";
            this.btn_AddWindow.Size = new System.Drawing.Size(132, 23);
            this.btn_AddWindow.TabIndex = 6;
            this.btn_AddWindow.Text = "Add to window";
            this.btn_AddWindow.UseVisualStyleBackColor = false;
            this.btn_AddWindow.Click += new System.EventHandler(this.btn_AddWindow_Click);
            // 
            // lbl_foodType
            // 
            this.lbl_foodType.AutoSize = true;
            this.lbl_foodType.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_foodType.Location = new System.Drawing.Point(235, 190);
            this.lbl_foodType.Name = "lbl_foodType";
            this.lbl_foodType.Size = new System.Drawing.Size(116, 25);
            this.lbl_foodType.TabIndex = 8;
            this.lbl_foodType.Text = "Food Type";
            // 
            // txb_FoodType
            // 
            this.txb_FoodType.Location = new System.Drawing.Point(367, 195);
            this.txb_FoodType.Name = "txb_FoodType";
            this.txb_FoodType.Size = new System.Drawing.Size(200, 20);
            this.txb_FoodType.TabIndex = 7;
            // 
            // btn_Viewwindow
            // 
            this.btn_Viewwindow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Viewwindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Viewwindow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Viewwindow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Viewwindow.Location = new System.Drawing.Point(440, 313);
            this.btn_Viewwindow.Name = "btn_Viewwindow";
            this.btn_Viewwindow.Size = new System.Drawing.Size(132, 23);
            this.btn_Viewwindow.TabIndex = 9;
            this.btn_Viewwindow.Text = "View Window ";
            this.btn_Viewwindow.UseVisualStyleBackColor = false;
            this.btn_Viewwindow.Click += new System.EventHandler(this.btn_Viewwindow_Click);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Viewwindow);
            this.Controls.Add(this.lbl_foodType);
            this.Controls.Add(this.txb_FoodType);
            this.Controls.Add(this.btn_AddWindow);
            this.Controls.Add(this.lbl_foodname);
            this.Controls.Add(this.txb_foodName);
            this.Controls.Add(this.lbl_datemade);
            this.Controls.Add(this.dtp_AddFood);
            this.Controls.Add(this.lbl_AddFood);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFood";
            this.Text = "Add Food Screen";
            this.Load += new System.EventHandler(this.AddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_AddFood;
        private System.Windows.Forms.Label lbl_foodname;
        private System.Windows.Forms.TextBox txb_foodName;
        private System.Windows.Forms.Label lbl_datemade;
        private System.Windows.Forms.DateTimePicker dtp_AddFood;
        private System.Windows.Forms.Button btn_AddWindow;
        private System.Windows.Forms.Button btn_Viewwindow;
        private System.Windows.Forms.Label lbl_foodType;
        private System.Windows.Forms.TextBox txb_FoodType;
    }
}