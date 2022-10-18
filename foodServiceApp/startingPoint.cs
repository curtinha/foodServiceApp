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
    public partial class startingPoint : Form
    {
       

         windowManager fm = new windowManager();

        public startingPoint(windowManager fm)
        {
            this.fm = fm;   
            InitializeComponent();
            
        }

        private void startingPoint_Load(object sender, EventArgs e)
        {

        }
        private void btn_sammy_MouseEnter(object sender, EventArgs e)
        {
            this.btn_sammy.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sammy_hover));
        }

        private void btn_sammy_MouseLeave(object sender, EventArgs e)
        {
            this.btn_sammy.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sammy));
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

         private void btn_Settings_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Settings.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Settings_Hover));
        }

        private void btn_Settings_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Settings.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Settings2));

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

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            {
                
                Settings f1 = new Settings(fm);
                f1.ShowDialog();
                
            }
        }

       
    

        private void btn_platter_Click(object sender, EventArgs e)
        {
            Global.foodIndex = 5;   
            this.Hide();
            AddFood window = new AddFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
            
        }

        private void btn_chicken_Click(object sender, EventArgs e)
        {   Global.foodIndex = 2;
            this.Hide();
            AddFood window = new AddFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_salad_Click(object sender, EventArgs e)
        {   Global.foodIndex = 3;
            this.Hide();
            AddFood window = new AddFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_seafood_Click(object sender, EventArgs e)
        {
            Global.foodIndex = 0;
            this.Hide();
            AddFood window = new AddFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_meat_Click(object sender, EventArgs e)
        {
            Global.foodIndex = 1;
            this.Hide();
            AddFood window = new AddFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_sammy_Click(object sender, EventArgs e)
        {
            Global.foodIndex = 4;
            this.Hide();
            AddFood window = new AddFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btn_viewWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DisplayWindow = new DisplayWindow(fm);
            DisplayWindow.FormClosed += (s, args) => this.Close();
            DisplayWindow.Show();
        }
    }
}
 
