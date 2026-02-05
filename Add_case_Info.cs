using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types; 

namespace project
{
    public partial class Add_case_Info : Form
    {
        public Add_case_Info()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = Home_page.conn;
            c.CommandText = "select COURT_ID from COURT";
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                CourtID.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DateTime db = DateTime.Parse(dobtxt.Text.ToString());
            int year = db.Year;
            OracleCommand cd = new OracleCommand();
            cd.Connection = Home_page.conn;
            cd.CommandText = "insert into Accused values(:accused_id,:court_id,:gender,:adder,:age,:dob,:fn,:ln,:state)";
            cd.Parameters.Add("accused_id", Int32.Parse(acc_id.Text.ToString()));
            cd.Parameters.Add("court_id", Int32.Parse(CourtID.SelectedItem.ToString()));
            cd.Parameters.Add("gender", cmbGen.Text.ToString());
            cd.Parameters.Add("adder", addrtxt.Text.ToString());
            cd.Parameters.Add("age", DateTime.Today.Year - year);
            cd.Parameters.Add("dob", dobtxt.Text.ToString());
            cd.Parameters.Add("fn", firstNametxt.Text.ToString());
            cd.Parameters.Add("ln", Lastnametxt.Text.ToString());
            cd.Parameters.Add("state", Statecmb.SelectedItem.ToString());
            int execc = cd.ExecuteNonQuery();
        
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Home_page.conn ;
            cmd.CommandText = "insert into CASE values(:case_id,:court_id,:case_name,:description,:case_date,:case_place,:case_type)";
            cmd.Parameters.Add("case_id",Int32.Parse(caseID.Text.ToString()));
            cmd.Parameters.Add("court_id", Int32.Parse(CourtID.SelectedItem.ToString()));
            cmd.Parameters.Add("case_name", caseName.Text.ToString());
            cmd.Parameters.Add("description", desc.Text.ToString());
            cmd.Parameters.Add("case_date",CaseDate.Text.ToString());
            cmd.Parameters.Add("case_place", CasePlace.Text.ToString());
            cmd.Parameters.Add("case_type", caseType.Text.ToString());
            int exec = cmd.ExecuteNonQuery();
           

            OracleCommand c = new OracleCommand();
            c.Connection = Home_page.conn;
            c.CommandText = "insert into CASE_ACCUSED values(:case_id,:accused_id)";
            c.Parameters.Add("case_id", Int32.Parse(caseID.Text.ToString()));
            c.Parameters.Add("accused_id", Int32.Parse(acc_id.Text.ToString()));
            int ee = c.ExecuteNonQuery();

            if (execc != -1)
            {
                MessageBox.Show("Accused Added Successfully");
                acc_id.Text = " ";
                firstNametxt.Text = " ";
                Lastnametxt.Text = " ";
                addrtxt.Text = " ";

            }

            if (exec != -1)
            {
                MessageBox.Show("Case Added Successfully");
                caseID.Text = " ";
                caseName.Text = " ";
                desc.Text = " ";
                caseType.Text = " ";
                CasePlace.Text = " ";

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void caseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
