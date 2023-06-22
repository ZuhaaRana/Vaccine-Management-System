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
    public partial class Update_Patient_Data : Form
    {
        public Update_Patient_Data()
        {
            InitializeComponent();
        }
        public string conString = "USER ID=XE;DATA SOURCE=DESKTOP-RHNR1O8;password=xe";

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_First_Name U_F_N = new Update_First_Name();
            U_F_N.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Last_Name U_L_N = new Update_Last_Name();
            U_L_N.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Age U_A = new Update_Age();
            U_A.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Gender U_G = new Update_Gender();
            U_G.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_DOC_ID U_D_I = new Update_DOC_ID();
            U_D_I.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Ph U_P = new Update_Ph();
            U_P.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PATIENT P = new PATIENT();
            P.ShowDialog();
        }
    }
}
