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
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float op, b, h;
            b = float.Parse(BaseTxt.Text);
            h = float.Parse(SidTxt.Text);
            op = b * h;
            ResTxt.Text = (op.ToString());
        }
    }
}
