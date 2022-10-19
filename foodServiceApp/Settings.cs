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
    public partial class Settings : Form
    {
        windowManager fm;

        public Settings(windowManager fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void btn_home_Click(object sender, EventArgs e) // returns the user back to the add food page (closes the settings overlay)
        {
            this.Close();
        }

    }
}
