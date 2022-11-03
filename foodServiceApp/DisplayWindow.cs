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
        SqlConnection connection; // stores connection string
        string connectionString;
      


        public displayWindow(windowManager fm)
        {
           
            InitializeComponent();
            this.fm = fm;
            connectionString = ConfigurationManager.ConnectionStrings["foodServiceApp.Properties.Settings.windowDBConnectionString"].ConnectionString;

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
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapater = new SqlDataAdapter("SELECT * FROM window WHERE foodID", connection)) ;
                
        }

        private void btn_current_Click(object sender, EventArgs e) // shows all foods which have not been marked expired
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapater = new SqlDataAdapter("SELECT * FROM window WHERE isEXPIRED=0", connection))
            {


                DataTable window = new DataTable();
                adapater.Fill(window);

                lbx_window.DisplayMember = "foodName";
                lbx_window.ValueMember = "foodID";
                lbx_window.DataSource = window;



            }

        }
    }
}