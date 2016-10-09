using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            fromdate = From.Text;
            todate = To.Text;
            thickness_Report tick = new thickness_Report();
            tick.Show();
            this.Hide();
        }

        private void Hardness_Report_Click(object sender, EventArgs e)
        {
            fromdate = From.Text;
            todate = To.Text;
            Hardness_Report hard = new Hardness_Report();
            hard.Show();
            this.Hide();
        }

        private void Glass_Report_Click(object sender, EventArgs e)
        {
            fromdate = From.Text;
            todate = To.Text;
            Gloss_Report gloss = new Gloss_Report();
            gloss.Show();
            this.Hide();

        }

        private void Adhesion_Report_Click(object sender, EventArgs e)
        {
            AdReport ad = new AdReport();
            ad.Show();
            this.Hide();
            fromdate = From.Text;
            todate = To.Text;
            
            
        }

        private void From_ValueChanged(object sender, EventArgs e)
        {
            From.MaxDate = DateTime.Today;
        }

        private void To_ValueChanged(object sender, EventArgs e)
        {
            To.MaxDate = DateTime.Today;
        }
    }
}
