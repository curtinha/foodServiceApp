using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Data.Common;


namespace foodServiceApp
{


    public partial class displayWindow : Form
    {
        windowManager fm;
        SqlConnection connection; // stores connection string
        string connectionString;
        
        



        public displayWindow(windowManager fm)
        {

            InitializeComponent();
            this.fm = fm;
            connectionString = ConfigurationManager.ConnectionStrings["foodServiceApp.Properties.Settings.windowDBConnectionString"].ConnectionString;
            lbx_window.SelectedIndex = -1;
        }

        private void btn_addFood_Click(object sender, EventArgs e) // loads add food window
        {
            this.Hide();
            addFood window = new addFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void displayWindow_Load(object sender, EventArgs e)
        {
            populateWindow(); // populates listbox
            
        }

        private void populateWindow() // this is the method which fills the listbox with stored values 
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapater = new SqlDataAdapter("SELECT * FROM window", connection))
            {


                DataTable window = new DataTable();
                adapater.Fill(window);

                lbx_window.DisplayMember = "foodName";
                lbx_window.ValueMember = "foodID";
                lbx_window.DataSource = window;
                


            }



        }

        private void btn_viewFoods_Click(object sender, EventArgs e)
        {
            populateWindow(); // repopulates for user to view all 
        }

        private void lbx_window_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
                
        }

        private void btn_current_Click(object sender, EventArgs e) // shows all foods which have not been marked expired
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapater = new SqlDataAdapter("SELECT * FROM window WHERE isExpired=0", connection))
            {


                DataTable window = new DataTable();
                adapater.Fill(window);

                

                lbx_window.DisplayMember = "foodName";
                lbx_window.ValueMember = "foodID";
                lbx_window.DataSource = window;



            }

            if(lbx_window.Items.Count < 1)
            {
                btn_expired.Enabled = false;
               
            }

        }

        private void btn_expired_Click(object sender, EventArgs e)
        {
            string query = "UPDATE window SET isExpired = @isExpired WHERE foodID = @foodID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@isExpired",1);
                command.Parameters.AddWithValue("@foodID", lbx_window.SelectedValue);
               

                
                command.ExecuteNonQuery(); // changes food to expired
                populateWindow();
            }
        }

        private void lbx_window_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbx_window.SelectedIndex != -1)
            {
                string selectedFood = "'" + lbx_window.Text + "'";
                string message = "";
                using (connection = new SqlConnection(connectionString))
                {
                    string queryString = $"SELECT * FROM window WHERE foodName = {selectedFood} ";

                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.HasRows == true)
                        {
                            reader.Read();

                            message = $"Selected Item:\nName:{reader["foodName"].ToString()}\nProduction Date: {reader["dateAdded "].ToString().Substring(0, 9)}\nType: {reader["foodType"].ToString()}";
                        }


                    }
                }

                MessageBox.Show(message);
            }
        }
    }
}