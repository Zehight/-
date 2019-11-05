using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 摄氏度_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            double f = 9.0 / 5 * c + 32;
            textBox2.Text = f.ToString();
        }
    }
}
