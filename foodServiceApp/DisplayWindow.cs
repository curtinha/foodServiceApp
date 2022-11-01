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


namespace foodServiceApp
{

  
    public partial class displayWindow : Form
    {
        windowManager fm;
        SqlConnection connection;
        string connectionString;
        int selectedIndex = -1;


        public displayWindow(windowManager fm)
        {
            this.fm = fm;
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["foodServiceApp.Properties.Settings.windowDBConnectionString"].ConnectionString;

        }       
        private void btn_addFood_Click(object sender, EventArgs e) // shows add food window
        {
            this.Hide();
            addFood window = new addFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void displayWindow_Load(object sender, EventArgs e)
        {
        populateWindow();
        }

        private void populateWindow()
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

        private void cbx_viewFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = cbx_viewCategory.SelectedIndex;

            if (selectedIndex == 0)
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapater = new SqlDataAdapter("SELECT * FROM window WHERE dateadded", connection))
                {


                    DataTable window = new DataTable();
                    adapater.Fill(window);

                    lbx_window.DisplayMember = "foodName";
                    lbx_window.ValueMember = "foodID";
                    lbx_window.DataSource = window;


                }

            else if (selectedIndex == 1)
            {
                    using (connection = new SqlConnection(connectionString))
                    using (SqlDataAdapter adapater = new SqlDataAdapter("SELECT * FROM window WHERE dateadded", connection))
                    {


                        DataTable window = new DataTable();
                        adapater.Fill(window);

                        lbx_window.DisplayMember = "foodName";
                        lbx_window.ValueMember = "foodID";
                        lbx_window.DataSource = window;

                    }

            else if (selectedIndex == 2)
            {


            }

            else if (selectedIndex == 3)
            {


            }

            else if (selectedIndex == 4)
            {

            }
        
        }

        
    }
            private void btn_viewFoods_Click(object sender, EventArgs e)
        {
            populateWindow();
        }
}
