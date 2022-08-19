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
    public partial class DisplayWindow : Form
    {
        public DisplayWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_viewFoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayWindow f1 = new DisplayWindow();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_addFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFood f1 = new AddFood();
            f1.ShowDialog();
            this.Close();
        }
    }
}
