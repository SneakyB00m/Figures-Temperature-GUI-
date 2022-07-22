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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float K, op,V=1.8f;
            K = float.Parse(Temp.Text);
            op = (K-273)*V+32;
            Res.Text = op.ToString();
        }
    }
}
