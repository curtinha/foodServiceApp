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

        windowManager fm;

        public AddFood(windowManager fm)
        {
            InitializeComponent();
            this.fm = fm;
            cbx_foodType.SelectedIndex = Global.foodIndex;
        }



        private void btn_AddWindow_Click(object sender, EventArgs e)
        {
            if (txb_foodName.Text == "")
            {
                MessageBox.Show("Please Enter a Food  ", "Error");
                txb_foodName.Focus();
            }
            else if(cbx_foodType.SelectedIndex == -1)
            {
               MessageBox.Show("Please Select a Type  ", "Error");
                cbx_foodType.Focus();
            }
            else
            {
                
                MessageBox.Show("Food Added!\nProduct Name: " + txb_foodName.Text + "\nProduct Type: " + cbx_foodType.Text + "\nProduction Date: " + dtp_AddFood.Text);
                clearfields();
                btn_Viewwindow.Enabled = true;
                
            }






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
            DisplayWindow window = new DisplayWindow(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }


        public void clearfields() // resets all fields in the form
        {
            txb_foodName.Text = "";
            cbx_foodType.SelectedIndex = -1;
            dtp_AddFood.Text = "";

        }

        private void txb_foodName_TextChanged(object sender, EventArgs e)
        {

        }




        private void cbx_foodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
