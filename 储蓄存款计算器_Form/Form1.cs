using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 储蓄存款计算器_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(textBox1.Text);
            double year = Convert.ToDouble(textBox3.Text);
            double rate = Convert.ToDouble(textBox2.Text)/100;
            double intereat = money * rate * year;
            textBox4.Text = intereat.ToString();
            double total = money + intereat;
            textBox5.Text = total.ToString();
        }
    }
}
