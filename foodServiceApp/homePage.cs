using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodServiceApp

{
    public partial class homePage : Form
    {
         windowManager fm = new windowManager(); // creates new instance of window manager

        public homePage(windowManager fm)
        {
            this.fm = fm;   
            InitializeComponent();
         

        }

        private void homePage_Shown(object sender, EventArgs e) // actions once form is shown on screen 
        {
           MessageBox.Show("Welcome to the Food Service App \nPlease click a food to add or view the current Display Window"); // displays welcome message
            
        }

        // the following methods change the image when the mouse hovers over them
        private void btn_sandwich_MouseEnter(object sender, EventArgs e)
        {
            this.btn_sandwich.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sandwich_hover));
        }

        private void btn_sandwich_MouseLeave(object sender, EventArgs e)
        {
            this.btn_sandwich.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sandwich1));
        }

        private void btn_seafood_MouseEnter(object sender, EventArgs e)
        {
            this.btn_seafood.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Craw_hover));
        }

        private void btn_seafood_MouseLeave(object sender, EventArgs e)
        {
            this.btn_seafood.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Craw));
        }
        private void btn_meat_MouseEnter(object sender, EventArgs e)
        {
            this.btn_meat.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Meat_Hover));
        }

        private void btn_meat_MouseLeave(object sender, EventArgs e)
        {
            this.btn_meat.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Meat));

        }

        private void btn_platter_MouseEnter(object sender, EventArgs e)
        {
            this.btn_platter.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Platter_hover));
        }

        private void btn_platter_MouseLeave(object sender, EventArgs e)
        {
            this.btn_platter.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Platter));

        }

         private void btn_settings_MouseEnter(object sender, EventArgs e)
        {
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.settings_Hover));
        }

        private void btn_settings_MouseLeave(object sender, EventArgs e)
        {
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.settings2));

        }

        private void btn_salad_MouseEnter(object sender, EventArgs e)
        {
            this.btn_salad.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.salad_hover));
        }

        private void btn_salad_MouseLeave(object sender, EventArgs e)
        {
            this.btn_salad.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Salad));

        }

        private void btn_chicken_MouseEnter(object sender, EventArgs e)
        {
            this.btn_chicken.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Chicken_hover));
        }

        private void btn_chicken_MouseLeave(object sender, EventArgs e)
        {
            this.btn_chicken.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.chick));

        }
        private void btn_viewWindow_MouseEnter(object sender, EventArgs e)
        {
            this.btn_chicken.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Store_Window_Hover_));
        }

        private void btn_viewWindow_MouseLeave(object sender, EventArgs e)
        {
            this.btn_chicken.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Store_Window_Hover_));

        }

        private void btn_settings_Click(object sender, EventArgs e) // loads the settings tab
        {
            {
                MessageBox.Show("Settings is Under Construction"); 
               
            }
        }
       
    // global foodIndex variable sets future cbx control corresponding to option selected (ease of use)

    // click methods load the new page with the correct index selected 

        private void btn_platter_Click(object sender, EventArgs e)
        {
            Global.foodIndex = 5;   
            this.Hide();
            addFood window = new addFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
            
        }

        private void btn_chicken_Click(object sender, EventArgs e)
        {   Global.foodIndex = 2;
            this.Hide();
            addFood window = new addFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_salad_Click(object sender, EventArgs e)
        {   Global.foodIndex = 3;
            this.Hide();
            addFood window = new addFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_seafood_Click(object sender, EventArgs e)
        {
            Global.foodIndex = 0;
            this.Hide();
            addFood window = new addFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_meat_Click(object sender, EventArgs e)
        {
            Global.foodIndex = 1;
            this.Hide();
            addFood window = new addFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_sandwich_Click(object sender, EventArgs e)
        {
            Global.foodIndex = 4;
            this.Hide();
            addFood window = new addFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

       // loads the window 

        private void btn_viewWindow_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            displayWindow window = new displayWindow(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
 
