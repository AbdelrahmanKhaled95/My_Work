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

        public string getFrom()
        {
            return fromdate;
        }
        public string getTo()
        {
            return todate;
        }
        public static string fromdate;
        public static string todate;
        
       


        private void Thickness_Report_Click(object sender, EventArgs e)
        {

        }

        private void Hardness_Report_Click(object sender, EventArgs e)
        {
            fromdate = From.Text;
            todate = To.Text;
            Hardness_Report hardnessreport = new Hardness_Report();
            hardnessreport.Show();
             
        }

        private void Thickness_Report_Click_1(object sender, EventArgs e)
        {
            fromdate = From.Text;
            todate = To.Text;
            Thickness_Report thicknessreport = new Thickness_Report();
            thicknessreport.Show();
             
        }

        private void Glass_Report_Click(object sender, EventArgs e)
        {
            fromdate = From.Text;
            todate = To.Text;
            Gloss_Report glossreport = new Gloss_Report();
            glossreport.Show();
             
        }

        private void Adhesion_Report_Click(object sender, EventArgs e)
        {
            fromdate = From.Text;
            todate = To.Text;
            Adhesion_Report adhesionreport = new Adhesion_Report();
            adhesionreport.Show();
             
        }

       

        private void To_ValueChanged(object sender, EventArgs e)
        {
            To.MaxDate = DateTime.Today;
        }

        private void From_ValueChanged(object sender, EventArgs e)
        {
            From.MaxDate = DateTime.Today;
        }

       

        
    }
}