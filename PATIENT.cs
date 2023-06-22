using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnection
{
    public partial class PATIENT : Form
    {
        public PATIENT()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Patient R_P = new Register_Patient();
            R_P.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Patient D_P = new Delete_Patient();
            D_P.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Patient_Data U_P_D = new Update_Patient_Data();
            U_P_D.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Search_Patient S_P = new Search_Patient();
            S_P.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
