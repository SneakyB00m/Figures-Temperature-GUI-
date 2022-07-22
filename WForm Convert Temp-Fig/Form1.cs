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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show
            userControl11.Show();
            userControl11.BringToFront();
            //hide
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show
            userControl21.Show();
            userControl21.BringToFront();
            //hide
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //show
            userControl31.Show();
            userControl31.BringToFront();
            //hide
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //show
            userControl41.Show();
            userControl41.BringToFront();
            //hide
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl51.Hide();
            userControl61.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //show
            userControl51.Show();
            userControl51.BringToFront();
            //hide
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl61.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //show
            userControl61.Show();
            userControl61.BringToFront();
            //hide
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl51.Hide();         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credits credits = new Credits();
            credits.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FiguresWF wF = new FiguresWF();
            wF.ShowDialog();
        }
    }
}
