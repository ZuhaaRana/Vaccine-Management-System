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
    public partial class Update_Last_Name : Form
    {
        public Update_Last_Name()
        {
            InitializeComponent();
        }
        public string conString = "USER ID=XE;DATA SOURCE=DESKTOP-RHNR1O8;password=xe";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "Update PATIENT SET (Last_Name) =  ('" + textBox2.Text.ToString() + "') WHERE (Patient_ID) = ('" + textBox1.Text.ToString() + "')";
                OracleCommand cmd = new OracleCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully...!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Patient_Data U_P_D = new Update_Patient_Data();
            U_P_D.ShowDialog();
        }
    }
}
