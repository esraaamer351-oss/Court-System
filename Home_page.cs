using System;
using System.ComponentModel;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using WindowsFormsApplication;

namespace project
{
    public partial class Home_page : Form
    {
        public string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        public static OracleConnection conn;
        public Home_page()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.home;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void addAccusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void addCaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (var t = new Add_case_Info())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void updateCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var t = new Update_Accused_state())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();

        }

        private void getAccusedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void getJudgmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void getCourtInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var t = new Show__all_Court_info())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var t = new Case_info_Report())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void getJudgmentReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            using (var t = new form6())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void getAccusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void getMaxAgeOfAccusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var t = new Get_Max_Accused_Age())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void getSpecificAccusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var t = new Get_Spcified_accused())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();

        }

        private void getCaseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var t = new show_Case_info())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }
    }
}
