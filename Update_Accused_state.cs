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
    public partial class Update_Accused_state : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Update_Accused_state()
        {
            InitializeComponent();
        }
      
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("updated successfully !!");
        }

        private void show_btn_Click_1(object sender, EventArgs e)
        {
            string constr = "Data Source=ORCL;User Id =scott; Password=tiger;";
            string cmdstr = "select ACCUSED_STATE,ACCUSED_ID from ACCUSED";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
