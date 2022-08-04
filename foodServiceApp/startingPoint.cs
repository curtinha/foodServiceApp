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
    public partial class startingPoint : Form
    {
        public startingPoint()
        {
            InitializeComponent();
        }

        private void startingPoint_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_blank2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sammy_Click(object sender, EventArgs e)
        {

        }

        private void btn_seafood_MouseEnter(object sender, EventArgs e)
        {
            this.btn_seafood.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Craw_hover));
        }

        private void btn_seafood_MouseLeave(object sender, EventArgs e)
        {
            this.btn_seafood.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Craw));
        }

        private void btn_seafood_Click(object sender, EventArgs e)
        {

        }
    }
}
