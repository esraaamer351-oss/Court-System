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


namespace project
{
    public partial class Get_Max_Accused_Age : Form
    {
        int age;

        public Get_Max_Accused_Age()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = Home_page.conn;
            c.CommandText = "Get_Accused_Age";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("accused_age", OracleDbType.Int32, ParameterDirection.Output);

            c.ExecuteNonQuery();
            try
            {
                dataGridView1.Rows.Add(c.Parameters["accused_age"].Value.ToString());
            }
            catch
            {
            }

        }
    }
}
