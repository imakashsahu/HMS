using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frm = new Home();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to enter the Guest Dashboard", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
                guest_v frm = new guest_v();
                frm.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to enter the Food Dashboard", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
                food_v frm = new food_v();
                frm.Show();
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to enter the Payment Dashboard", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
                v_pay frm = new v_pay();
                frm.Show();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            bill frm = new bill();
            frm.Show();
        }
    }
}
