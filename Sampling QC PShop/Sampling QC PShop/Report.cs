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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Main main = new Main();
                main.Show();
            }

        }

       
        public string getDate()
        {
            return Date.Text;
        }
        public string getDateTimePicker1()
        {
            return dateTimePicker1.Text;
        }
        private void From_ValueChanged(object sender, EventArgs e)
        {
            Date.MaxDate = DateTime.Today;
            
        }

        private void Thickness_Report_Click(object sender, EventArgs e)
        {

        }

        private void Hardness_Report_Click(object sender, EventArgs e)
        {
            Hardness_Report hardnessreport = new Hardness_Report();
            hardnessreport.Show();
        }

        private void Thickness_Report_Click_1(object sender, EventArgs e)
        {
            Thickness_Report thicknessreport = new Thickness_Report();
            thicknessreport.Show();
        }

        private void Glass_Report_Click(object sender, EventArgs e)
        {
            Gloss_Report glossreport = new Gloss_Report();
            glossreport.Show();
        }

        private void Adhesion_Report_Click(object sender, EventArgs e)
        {
            Adhesion_Report adhesionreport = new Adhesion_Report();
            adhesionreport.Show();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            Date.MaxDate = DateTime.Today;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

       

        
    }
}