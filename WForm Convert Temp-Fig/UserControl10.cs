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
    public partial class UserControl10 : UserControl
    {
        public UserControl10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float op, r,pi=3.1415f;
            r = float.Parse(Rtxt.Text);
            op = r*r*pi;
            ResTxt.Text=(op.ToString());
        }
    }
}
