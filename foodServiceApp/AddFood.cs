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
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }

 

        private void btn_AddWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Food Details are as follows\nFood:\nFood Type:\nExp Date:");
            txb_foodName.Text = "";
            txb_FoodType.Text = "";



        }

        private void AddFood_Load(object sender, EventArgs e)
        {

        }

        private void lbl_datemade_Click(object sender, EventArgs e)
        {

        }

        private void btn_Viewwindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayWindow f1 = new DisplayWindow();
            f1.ShowDialog();
            this.Close();
        }
    }
}
