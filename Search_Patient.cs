using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace TestConnection
{
    public partial class Search_Patient : Form
    {
        public Search_Patient()
        {
            InitializeComponent();
        }
        public string conString = "USER ID=XE;DATA SOURCE=DESKTOP-RHNR1O8;password=xe";
        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM PATIENT WHERE PATIENT_ID = '" + textBox1.Text.ToString() + "'";
                OracleCommand cmd = new OracleCommand(q, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            con.Close();
      
        }
    }
}
