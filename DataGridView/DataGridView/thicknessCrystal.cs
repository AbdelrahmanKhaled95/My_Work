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
    public partial class thicknessCrystal : Form
    {
        public thicknessCrystal()
        {
            Main main=new Main();
            InitializeComponent();
            CrystalReport1 crystal = new CrystalReport1();
            crystal.SetParameterValue("@from", main.getFrom());
            crystal.SetParameterValue("@to", main.getTo());
            crystalReportViewer1.ReportSource = crystal;
        }
    }
}
