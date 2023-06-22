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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string conString = "USER ID=XE;DATA SOURCE=DESKTOP-RHNR1O8;password=xe";
        private void button4_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into LOGIN(username,password)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')";
                OracleCommand cmd = new OracleCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Logged in successfully..!");


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }
    }
}
