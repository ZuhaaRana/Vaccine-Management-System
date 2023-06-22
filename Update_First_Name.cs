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
    public partial class Update_First_Name : Form
    {
        public Update_First_Name()
        {
            InitializeComponent();
        }
        public string conString = "USER ID=XE;DATA SOURCE=DESKTOP-RHNR1O8;password=xe";
        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "Update PATIENT SET (First_Name) =  ('" + textBox2.Text.ToString() + "') WHERE (Patient_ID) = ('" + textBox1.Text.ToString() + "')";
                OracleCommand cmd = new OracleCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully...!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Patient_Data U_P_D = new Update_Patient_Data();
            U_P_D.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
