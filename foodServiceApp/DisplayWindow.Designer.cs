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
            this.btn_viewall = new System.Windows.Forms.Button();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.lbx_window = new System.Windows.Forms.ListBox();
            this.btn_current = new System.Windows.Forms.Button();
            this.btn_expired = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_viewWindow
            // 
            this.lbl_viewWindow.AutoSize = true;
            this.lbl_viewWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_viewWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_viewWindow.Location = new System.Drawing.Point(413, 9);
            this.lbl_viewWindow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_viewWindow.Name = "lbl_viewWindow";
            this.lbl_viewWindow.Size = new System.Drawing.Size(248, 69);
            this.lbl_viewWindow.TabIndex = 0;
            this.lbl_viewWindow.Text = "Window";
            // 
            // btn_viewall
            // 
            this.btn_viewall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_viewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewall.Location = new System.Drawing.Point(340, 415);
            this.btn_viewall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(205, 57);
            this.btn_viewall.TabIndex = 7;
            this.btn_viewall.Text = "View All";
            this.btn_viewall.UseVisualStyleBackColor = false;
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewFoods_Click);
            // 
            // btn_addFood
            // 
            this.btn_addFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addFood.Location = new System.Drawing.Point(553, 415);
            this.btn_addFood.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(205, 57);
            this.btn_addFood.TabIndex = 8;
            this.btn_addFood.Text = "Add Food ";
            this.btn_addFood.UseVisualStyleBackColor = true;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // lbx_window
            // 
            this.lbx_window.FormattingEnabled = true;
            this.lbx_window.ItemHeight = 16;
            this.lbx_window.Location = new System.Drawing.Point(340, 101);
            this.lbx_window.Margin = new System.Windows.Forms.Padding(4);
            this.lbx_window.Name = "lbx_window";
            this.lbx_window.Size = new System.Drawing.Size(418, 212);
            this.lbx_window.TabIndex = 10;
            this.lbx_window.SelectedIndexChanged += new System.EventHandler(this.lbx_window_SelectedIndexChanged);
            // 
            // btn_current
            // 
            this.btn_current.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_current.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_current.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_current.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_current.Location = new System.Drawing.Point(340, 336);
            this.btn_current.Margin = new System.Windows.Forms.Padding(4);
            this.btn_current.Name = "btn_current";
            this.btn_current.Size = new System.Drawing.Size(205, 57);
            this.btn_current.TabIndex = 11;
            this.btn_current.Text = "View Current";
            this.btn_current.UseVisualStyleBackColor = false;
            this.btn_current.Click += new System.EventHandler(this.btn_current_Click);
            // 
            // btn_expired
            // 
            this.btn_expired.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_expired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expired.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_expired.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_expired.Location = new System.Drawing.Point(553, 336);
            this.btn_expired.Margin = new System.Windows.Forms.Padding(4);
            this.btn_expired.Name = "btn_expired";
            this.btn_expired.Size = new System.Drawing.Size(205, 57);
            this.btn_expired.TabIndex = 12;
            this.btn_expired.Text = "Mark Selected Food Expired";
            this.btn_expired.UseVisualStyleBackColor = false;
            this.btn_expired.Click += new System.EventHandler(this.btn_expired_Click);
            // 
            // displayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_expired);
            this.Controls.Add(this.btn_current);
            this.Controls.Add(this.lbx_window);
            this.Controls.Add(this.btn_addFood);
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.lbl_viewWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btn_viewall;
        private System.Windows.Forms.Button btn_addFood;
        private System.Windows.Forms.ListBox lbx_window;
        private System.Windows.Forms.Button btn_current;
        private System.Windows.Forms.Button btn_expired;
    }
}