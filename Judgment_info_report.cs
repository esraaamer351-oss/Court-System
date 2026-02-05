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
using project;

namespace WindowsFormsApplication
{
    public partial class form6 : Form
    {
        CrystalReport2 crr;
        public form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer2.ReportSource = crr;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crr = new CrystalReport2();
            foreach (ParameterDiscreteValue va in crr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(va.Value);
        }
    }
}
