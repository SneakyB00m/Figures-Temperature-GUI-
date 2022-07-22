using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degrees
{
    public partial class UserControl11 : UserControl
    {
        public UserControl11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float op, h, b;
            h = float.Parse(HeightTxt.Text);
            b = float.Parse(BaseTxt.Text);
            op = b * h / 2;
            ResTxt.Text = (op.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ResTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeightTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BaseTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
