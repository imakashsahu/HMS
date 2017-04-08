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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Home frm = new Home();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button3, 0, button3.Height);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button3.BackColor = Color.Red;

                room_book frm = new room_book();
                frm.Show();
            }
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();
        }

        private void underMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Orange;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(button4, 0, button4.Height);
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button4.BackColor = Color.Red;

                rn2 frm = new rn2();
                frm.Show();
            }
        }

        private void checkOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Orange;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button14.BackColor = Color.Red;

                rn3 frm = new rn3();
                frm.Show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(button14, 0, button14.Height);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Orange;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            contextMenuStrip4.Show(button13, 0, button13.Height);

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button13.BackColor = Color.Red;

                rn4 frm = new rn4();
                frm.Show();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Orange;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            contextMenuStrip5.Show(button6, 0, button6.Height);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button6.BackColor = Color.Red;

                rn11 frm = new rn11();
                frm.Show();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Orange;

        }

        private void button5_Click(object sender, EventArgs e)
        {


            contextMenuStrip6.Show(button5, 0, button5.Height);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button5.BackColor = Color.Red;

                rn12 frm = new rn12();
                frm.Show();
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {


            button5.BackColor = Color.Orange;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            contextMenuStrip7.Show(button12, 0, button12.Height);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button12.BackColor = Color.Red;

                rn13 frm = new rn13();
                frm.Show();
            }

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Orange;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            contextMenuStrip8.Show(button11, 0, button11.Height);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button11.BackColor = Color.Red;

                rn14 frm = new rn14();
                frm.Show();
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Orange;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            contextMenuStrip9.Show(button8, 0, button8.Height);
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button8.BackColor = Color.Red;

                rn21 frm = new rn21();
                frm.Show();
            }
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();

        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Orange;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contextMenuStrip10.Show(button7, 0, button7.Height);
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button7.BackColor = Color.Red;

                rn22 frm = new rn22();
                frm.Show();
            }
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Orange;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            contextMenuStrip11.Show(button10, 0, button10.Height);
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button10.BackColor = Color.Red;

                rn23 frm = new rn23();
                frm.Show();
            }
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Orange;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            contextMenuStrip12.Show(button9, 0, button9.Height);

        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have You Registered the NEW GUEST ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                button13.BackColor = Color.Red;

                rn24 frm = new rn24();
                frm.Show();
            }
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {

            button9.BackColor = Color.LimeGreen;
            checkout frm = new checkout();
            frm.Show();
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Orange;
        }
    }
}
