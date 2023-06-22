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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public string conString = "USER ID=XE;DATA SOURCE=DESKTOP-RHNR1O8;password=xe";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       // private void button1_Click(object sender, EventArgs e)
       // {
            //OracleConnection con = new OracleConnection(conString);
            //con.Open();
            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    string q = "insert into LOGIN(username,password)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')";
            //    OracleCommand cmd = new OracleCommand(q, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Connection made Successfully..!");
            //}
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                this.Hide();
                Form2 F2 = new Form2();
                F2.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F4 = new Form4();
            F4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DOCTOR D = new DOCTOR();
            D.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PATIENT P = new PATIENT();
            P.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            APPOINTMENTS AP = new APPOINTMENTS();
            AP.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
