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

namespace foodServiceApp
{

  
    public partial class displayWindow : Form
    {
        windowManager fm;

        public displayWindow(windowManager fm)
        {
            this.fm = fm;
            InitializeComponent();

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

        }

   
    }
}
