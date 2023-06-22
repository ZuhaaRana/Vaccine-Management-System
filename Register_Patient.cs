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
    public partial class Register_Patient : Form
    {
        public Register_Patient()
        {
            InitializeComponent();
        }
        public string conString = "USER ID=XE;DATA SOURCE=DESKTOP-RHNR1O8;password=xe";
        //Back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PATIENT P = new PATIENT();
            P.ShowDialog();
        }
        //Register Patient button
        private void button5_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(conString);
            con.Open();

            string A = "Select PATIENT_ID FROM PATIENT WHERE PATIENT_ID = '" + textBox1.Text + "'";
            OracleCommand cmd2 = new OracleCommand(A, con);
            cmd2.Parameters.Add("PATIENT_ID", textBox1.Text);
            OracleDataReader myreader = cmd2.ExecuteReader();
            if (myreader.Read())
            {
                con.Close();
                MessageBox.Show("Duplicate Patient ID");
                textBox1.Text = " ";
            }
            else
            {
                //con.Close();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "INSERT into PATIENT(Patient_ID,First_Name,Last_Name,Age,Gender,Doc_ID,Phone_No)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                    OracleCommand cmd = new OracleCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Inserted Successfully...!");
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";
                    textBox5.Text = " ";
                    textBox6.Text = " ";
                    textBox7.Text = " ";
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
