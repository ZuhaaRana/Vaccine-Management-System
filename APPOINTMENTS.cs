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
    public partial class APPOINTMENTS : Form
    {
        public APPOINTMENTS()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            APPOINTMENTS AP = new APPOINTMENTS();
            AP.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Book_Appointment B_A = new Book_Appointment();
            B_A.ShowDialog();
        }
    }
}
