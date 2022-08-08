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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_AddFood = new System.Windows.Forms.Label();
            this.dtp_AddFood = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddWindow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lbl_AddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_AddFood.Location = new System.Drawing.Point(301, 30);
            this.lbl_AddFood.Name = "lbl_AddFood";
            this.lbl_AddFood.Size = new System.Drawing.Size(165, 39);
            this.lbl_AddFood.TabIndex = 0;
            this.lbl_AddFood.Text = "Add Food";
            this.lbl_AddFood.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtp_AddFood
            // 
            this.dtp_AddFood.CalendarTrailingForeColor = System.Drawing.Color.DodgerBlue;
            this.dtp_AddFood.Location = new System.Drawing.Point(372, 199);
            this.dtp_AddFood.Name = "dtp_AddFood";
            this.dtp_AddFood.Size = new System.Drawing.Size(200, 20);
            this.dtp_AddFood.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Made";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Food Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "As of now the food date will be preset (messagebox show exp date)";
            // 
            // btn_AddWindow
            // 
            this.btn_AddWindow.Location = new System.Drawing.Point(270, 316);
            this.btn_AddWindow.Name = "btn_AddWindow";
            this.btn_AddWindow.Size = new System.Drawing.Size(132, 23);
            this.btn_AddWindow.TabIndex = 6;
            this.btn_AddWindow.Text = "Add to window";
            this.btn_AddWindow.UseVisualStyleBackColor = true;
            this.btn_AddWindow.Click += new System.EventHandler(this.btn_AddWindow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Food Type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(372, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "View Current Window ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_AddWindow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_AddFood);
            this.Controls.Add(this.lbl_AddFood);
            this.Name = "AddFood";
            this.Text = "Add Food Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_AddFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_AddFood;
        private System.Windows.Forms.Button btn_AddWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}