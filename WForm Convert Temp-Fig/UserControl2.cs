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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float F, op,op2,op3, V=1.8f;
            F = float.Parse(Temp.Text);
            op = F - 32;
            op2 = op / V;
            op3 = op2 + 273;
            Restxt.Text = op3.ToString();
        }
    }
}
