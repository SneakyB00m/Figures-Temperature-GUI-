using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degrees
{
    public partial class FiguresWF : Form
    {
        public FiguresWF()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> action = null;
            action = (Controls) =>
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else

                        action(control.Controls);

                }
            };
            action(Controls);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show           
            userControl71.Show();
            userControl71.BringToFront();
            //hide
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //show           
            userControl81.Show();
            userControl81.BringToFront();
            //hide
            userControl71.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show           
            userControl91.Show();
            userControl91.BringToFront();
            //hide
            userControl71.Hide();
            userControl81.Hide();
            userControl101.Hide();
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //show           
            userControl101.Show();
            userControl101.BringToFront();
            //hide
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FiguresWF_Load(object sender, EventArgs e)
        {
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //show           
            userControl111.Show();
            userControl111.BringToFront();
            //hide
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl121.Hide();
            userControl131.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //show           
            userControl121.Show();
            userControl121.BringToFront();
            //hide
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl111.Hide();
            userControl131.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //show           
            userControl131.Show();
            userControl131.BringToFront();
            //hide
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl111.Hide();
            userControl121.Hide();
        }

        private void userControl121_Load(object sender, EventArgs e)
        {

        }

        private void userControl131_Load(object sender, EventArgs e)
        {

        }
    }
}