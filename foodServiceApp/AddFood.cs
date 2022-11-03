using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace foodServiceApp
{
    public partial class addFood : Form
    {
        string connectionString;
        SqlConnection connection;

        windowManager fm;
        public addFood(windowManager fm)
        {
            InitializeComponent();
            this.fm = fm;
            cbx_foodType.SelectedIndex = Global.foodIndex; // carries through selected user food option
            connectionString = ConfigurationManager.ConnectionStrings["foodServiceApp.Properties.Settings.windowDBConnectionString"].ConnectionString;
        }

        private void addFood_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_addWindow_Click(object sender, EventArgs e)
        { // data verification loop - prevents user from entering nothing
            if (txb_foodName.Text == "")
            {
                MessageBox.Show("Please Enter a Food  ", "Error");
                txb_foodName.Focus();
                lbl_foodname.ForeColor = Color.Red; // changes the forms elements to red to inform the user of what they need to add
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
                
                btn_viewWindow.Enabled = true; // allows the user to view what foods they have added 
                clearfields();
                string query = "INSERT INTO window VALUES (@foodName, @foodType, @dateAdded, @isExpired)";
                
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@foodName", txb_foodName.Text);
                    command.Parameters.AddWithValue("@foodType", cbx_foodType.Text);
                    command.Parameters.AddWithValue("@dateAdded", dtp_addFood.Value);
                    command.Parameters.AddWithValue("@dateAdded", dtp_addFood.Value);
                    command.Parameters.AddWithValue("@isExpired", 0);

                    command.ExecuteNonQuery();
                }

                clearfields();

            }

        }

        private void btn_viewWindow_Click(object sender, EventArgs e) // loads view window form
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
