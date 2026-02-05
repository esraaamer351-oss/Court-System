using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace project
{
    public partial class Case_info_Report : Form
    {
        CrystalReport1 cr;
        public Case_info_Report()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                casename_cmb.Items.Add(v.Value);
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0,casename_cmb.Text);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
