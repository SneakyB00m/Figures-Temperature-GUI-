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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float K, Op;
            K = float.Parse(Temp.Text);
            Op = K - 273;
            Res.Text = Op.ToString();
        }
    }
}
