using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sampling_QC_PShop
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

       

        private void Thickness_Click_1(object sender, EventArgs e)
        {
            delthick delthicke = new delthick();
            delthicke.Show();
        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
             
        }

        private void Hardness_Click(object sender, EventArgs e)
        {
            delhard delharde = new delhard();
            delharde.Show();
        }

        private void Glass_Click(object sender, EventArgs e)
        {
            delgloss delglosse = new delgloss();
            delglosse.Show();
        }

        private void Adhesion_Click(object sender, EventArgs e)
        {
            delad delade = new delad();
            delade.Show();

        }
    }
}