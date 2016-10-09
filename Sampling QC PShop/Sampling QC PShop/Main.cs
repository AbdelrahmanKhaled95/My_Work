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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Thickness_Click(object sender, EventArgs e)
        {
            Thickness go = new Thickness();
            go.Show();

        }

        private void About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();

        }

        private void Hardness_Click(object sender, EventArgs e)
        {
            Hardness hardness = new Hardness();
            hardness.Show();

        }

        private void Glass_Click(object sender, EventArgs e)
        {
            Gloss gloss = new Gloss();
            gloss.Show();


        }

        private void Adhesion_Click(object sender, EventArgs e)
        {
            Adhesion adhesion = new Adhesion();
            adhesion.Show();

        }

        private void Report_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.getName()=="Admin")
            {

                Admin admin = new Admin();
                admin.Show();

            }
            else
            {
                MessageBox.Show("ليس لديك تصريح بالدخول");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}