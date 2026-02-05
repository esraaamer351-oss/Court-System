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
    public partial class show_Case_info : Form
    {
        public show_Case_info()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Home_page.conn;
            cmd.CommandText = "GET_CASE_INFO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("info", OracleDbType.RefCursor, ParameterDirection.Output);
            var dataReader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridView1.DataSource = dataTable;
            dataReader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void la_Click(object sender, EventArgs e)
        {

        }
    }
}
