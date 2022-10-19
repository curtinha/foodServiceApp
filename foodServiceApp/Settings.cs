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
        windowManager fm = new windowManager();

        public Settings(windowManager fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //private void btn_submitSettings_Click(object sender, EventArgs e)
        //{

        //    am.SetSpeciesParameters(cbx_species.Text, nud_cost.Value);


        //    this.Hide();
        //    HomePage window = new HomePage(am);
        //    window.FormClosed += (s, args) => this.Close();
        //    window.Show();




        //}

        //private void cbx_species_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<decimal> settings = am.GetAnimalSettings(cbx_species.Text);
        //    nud_cost.Value = settings[0];  // updates the animal cost according to which index has been changed in the NUD }





    }
}
