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
    public partial class addFood : Form
    {
        windowManager fm;
        public addFood(windowManager fm)
        {
            InitializeComponent();
            this.fm = fm;
            cbx_foodType.SelectedIndex = Global.foodIndex; // carries through selected user food option
        }

        private void btn_addWindow_Click(object sender, EventArgs e)
        { // data verification loop - prevents user from entering nothing
            if (txb_foodName.Text == "")
            {
                MessageBox.Show("Please Enter a Food  ", "Error");
                txb_foodName.Focus();
                lbl_foodname.ForeColor = Color.Red;
            }
            else if(cbx_foodType.SelectedIndex == -1)
            {
               MessageBox.Show("Please Select a Type  ", "Error");
                cbx_foodType.Focus();
                lbl_foodType.ForeColor = Color.Red;
            }
            else
            {
                
                MessageBox.Show("Food Added!\nProduct Name: " + txb_foodName.Text + "\nProduct Type: " + cbx_foodType.Text + "\nProduction Date: " + dtp_addFood.Text);
                clearfields();
                btn_viewWindow.Enabled = true;
                
            }

        }

        private void addFood_Load(object sender, EventArgs e)
        {

        }


        private void btn_viewWindow_Click(object sender, EventArgs e) // loads window form
        {
            this.Hide();
            displayWindow window = new displayWindow(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }


        public void clearfields() // resets all fields in the form
        {
            lbl_foodname.ForeColor = Color.WhiteSmoke;
            lbl_foodType.ForeColor = Color.WhiteSmoke;
            txb_foodName.Text = "";
            dtp_addFood.Text = "";
            Global.foodIndex = -1;
            cbx_foodType.SelectedIndex = -1;

        }

    }
}
