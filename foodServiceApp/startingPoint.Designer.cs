
namespace foodServiceApp
{
    partial class startingPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startingPoint));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_platter = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_seafood = new System.Windows.Forms.Button();
            this.btn_chicken = new System.Windows.Forms.Button();
            this.btn_meat = new System.Windows.Forms.Button();
            this.btn_salad = new System.Windows.Forms.Button();
            this.btn_viewWindow = new System.Windows.Forms.Button();
            this.btn_sammy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(193, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(438, 56);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Food Display App\r\n";
            // 
            // btn_platter
            // 
            this.btn_platter.BackColor = System.Drawing.Color.White;
            this.btn_platter.BackgroundImage = global::foodServiceApp.Properties.Resources.Platter;
            this.btn_platter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_platter.ForeColor = System.Drawing.Color.DimGray;
            this.btn_platter.Location = new System.Drawing.Point(460, 190);
            this.btn_platter.Name = "btn_platter";
            this.btn_platter.Size = new System.Drawing.Size(100, 100);
            this.btn_platter.TabIndex = 8;
            this.btn_platter.UseVisualStyleBackColor = false;
            this.btn_platter.Click += new System.EventHandler(this.btn_platter_Click);
            this.btn_platter.MouseEnter += new System.EventHandler(this.btn_platter_MouseEnter);
            this.btn_platter.MouseLeave += new System.EventHandler(this.btn_platter_MouseLeave);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackgroundImage = global::foodServiceApp.Properties.Resources.Settings2;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Location = new System.Drawing.Point(460, 296);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Settings.Size = new System.Drawing.Size(100, 100);
            this.btn_Settings.TabIndex = 7;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            this.btn_Settings.MouseEnter += new System.EventHandler(this.btn_Settings_MouseEnter);
            this.btn_Settings.MouseLeave += new System.EventHandler(this.btn_Settings_MouseLeave);
            // 
            // btn_seafood
            // 
            this.btn_seafood.BackgroundImage = global::foodServiceApp.Properties.Resources.Craw;
            this.btn_seafood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_seafood.Location = new System.Drawing.Point(460, 84);
            this.btn_seafood.Name = "btn_seafood";
            this.btn_seafood.Size = new System.Drawing.Size(100, 100);
            this.btn_seafood.TabIndex = 6;
            this.btn_seafood.UseVisualStyleBackColor = true;
            this.btn_seafood.Click += new System.EventHandler(this.btn_seafood_Click);
            this.btn_seafood.MouseEnter += new System.EventHandler(this.btn_seafood_MouseEnter);
            this.btn_seafood.MouseLeave += new System.EventHandler(this.btn_seafood_MouseLeave);
            // 
            // btn_chicken
            // 
            this.btn_chicken.BackgroundImage = global::foodServiceApp.Properties.Resources.chick;
            this.btn_chicken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chicken.Location = new System.Drawing.Point(354, 190);
            this.btn_chicken.Name = "btn_chicken";
            this.btn_chicken.Size = new System.Drawing.Size(100, 100);
            this.btn_chicken.TabIndex = 5;
            this.btn_chicken.UseVisualStyleBackColor = true;
            this.btn_chicken.Click += new System.EventHandler(this.btn_chicken_Click);
            this.btn_chicken.MouseEnter += new System.EventHandler(this.btn_chicken_MouseEnter);
            this.btn_chicken.MouseLeave += new System.EventHandler(this.btn_chicken_MouseLeave);
            // 
            // btn_meat
            // 
            this.btn_meat.BackgroundImage = global::foodServiceApp.Properties.Resources.Meat;
            this.btn_meat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_meat.Location = new System.Drawing.Point(354, 84);
            this.btn_meat.Name = "btn_meat";
            this.btn_meat.Size = new System.Drawing.Size(100, 100);
            this.btn_meat.TabIndex = 3;
            this.btn_meat.UseVisualStyleBackColor = true;
            this.btn_meat.Click += new System.EventHandler(this.btn_meat_Click);
            this.btn_meat.MouseEnter += new System.EventHandler(this.btn_meat_MouseEnter);
            this.btn_meat.MouseLeave += new System.EventHandler(this.btn_meat_MouseLeave);
            // 
            // btn_salad
            // 
            this.btn_salad.BackgroundImage = global::foodServiceApp.Properties.Resources.Salad;
            this.btn_salad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salad.Location = new System.Drawing.Point(248, 190);
            this.btn_salad.Name = "btn_salad";
            this.btn_salad.Size = new System.Drawing.Size(100, 100);
            this.btn_salad.TabIndex = 2;
            this.btn_salad.UseVisualStyleBackColor = true;
            this.btn_salad.Click += new System.EventHandler(this.btn_salad_Click);
            this.btn_salad.MouseEnter += new System.EventHandler(this.btn_salad_MouseEnter);
            this.btn_salad.MouseLeave += new System.EventHandler(this.btn_salad_MouseLeave);
            // 
            // btn_viewWindow
            // 
            this.btn_viewWindow.BackColor = System.Drawing.Color.White;
            this.btn_viewWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewWindow.ForeColor = System.Drawing.Color.DimGray;
            this.btn_viewWindow.Image = global::foodServiceApp.Properties.Resources.Store_Window2;
            this.btn_viewWindow.Location = new System.Drawing.Point(248, 296);
            this.btn_viewWindow.Name = "btn_viewWindow";
            this.btn_viewWindow.Size = new System.Drawing.Size(206, 100);
            this.btn_viewWindow.TabIndex = 1;
            this.btn_viewWindow.UseVisualStyleBackColor = false;
            this.btn_viewWindow.Click += new System.EventHandler(this.btn_viewWindow_Click_1);
            // 
            // btn_sammy
            // 
            this.btn_sammy.BackgroundImage = global::foodServiceApp.Properties.Resources.sammy;
            this.btn_sammy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sammy.Location = new System.Drawing.Point(248, 84);
            this.btn_sammy.Name = "btn_sammy";
            this.btn_sammy.Size = new System.Drawing.Size(100, 100);
            this.btn_sammy.TabIndex = 0;
            this.btn_sammy.UseVisualStyleBackColor = true;
            this.btn_sammy.Click += new System.EventHandler(this.btn_sammy_Click);
            this.btn_sammy.MouseEnter += new System.EventHandler(this.btn_sammy_MouseEnter);
            this.btn_sammy.MouseLeave += new System.EventHandler(this.btn_sammy_MouseLeave);
            // 
            // startingPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_platter);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_seafood);
            this.Controls.Add(this.btn_chicken);
            this.Controls.Add(this.btn_meat);
            this.Controls.Add(this.btn_salad);
            this.Controls.Add(this.btn_viewWindow);
            this.Controls.Add(this.btn_sammy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "startingPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.startingPoint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sammy;
        private System.Windows.Forms.Button btn_viewWindow;
        private System.Windows.Forms.Button btn_salad;
        private System.Windows.Forms.Button btn_chicken;
        private System.Windows.Forms.Button btn_meat;
        private System.Windows.Forms.Button btn_platter;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_seafood;
        private System.Windows.Forms.Label lbl_title;
    }
}

