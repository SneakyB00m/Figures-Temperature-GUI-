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
    public partial class UserControl13 : UserControl
    {
        public UserControl13()
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
    }
}
