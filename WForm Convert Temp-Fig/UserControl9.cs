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
    public partial class UserControl9 : UserControl
    {
        public UserControl9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float op, b, h;
            b = float.Parse(Basetxt.Text);
            h = float.Parse(HeightTxt.Text);
            op = b * h;
            ResTxt.Text = (op.ToString());
        }
    }
}
