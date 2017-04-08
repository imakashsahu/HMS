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
    public partial class Admin_home : Form
    {
        public Admin_home()
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to enter the Front Office Dashboard", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
                report frm = new report();
                frm.Show();
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to enter the Front Office Dashboard", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
                Home frm = new Home();
                frm.Show();
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to enter the Front Office Dashboard", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
                Room frm = new Room();
                frm.Show();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to enter the Front Office Dashboard", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
                food frm = new food();
                frm.Show();
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            user frm = new user();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff frm = new staff();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff frm = new staff();
            frm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
