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
        public AddFood()
        {
            InitializeComponent();
        }

 

        private void btn_AddWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Food Details are as follows");

        }
    }
}
