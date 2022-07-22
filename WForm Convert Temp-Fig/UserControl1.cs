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
    public partial class UserControl1 : UserControl
    {        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float F, op;
            F = float.Parse(Temp.Text);
            op = (F - 32)*5/9;
            Restxt.Text=(op.ToString());

        }

        private void Restxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
