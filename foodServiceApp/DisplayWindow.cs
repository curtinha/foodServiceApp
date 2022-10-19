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
        windowManager fm;

        public DisplayWindow(windowManager fm)
        {
            this.fm = fm;
            InitializeComponent();

        }       
        private void btn_addFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFood window = new AddFood(fm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void DisplayWindow_Load(object sender, EventArgs e)
        {

        }

   
    }
}
