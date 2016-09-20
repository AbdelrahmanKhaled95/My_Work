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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label7_ParentChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        
            {
                Main main = new Main();
                main.Show();
            }
        
    }
}