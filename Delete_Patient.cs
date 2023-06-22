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
    public partial class Delete_Patient : Form
    {
        public Delete_Patient()
        {
            InitializeComponent();
        }
        public string conString = "USER ID=XE;DATA SOURCE=DESKTOP-RHNR1O8;password=xe";
       
       private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PATIENT P = new PATIENT();
            P.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "Delete From PATIENT WHERE (Patient_ID) = ('" + textBox1.Text.ToString()  + "')";
                OracleCommand cmd = new OracleCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data deleted Successfully...!");
            }
        }
    }
}
