using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notpad
{
    public partial class parent : Form
    {
        public parent()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChild child = new FrmChild();
            //child.MdiParent = this;
            child.Show();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            frm.Close();
        }

        private void 关闭全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取父窗体中包含的子窗体数组
            foreach (Form frm in this.MdiChildren)
            {
                //遍历到激活窗体，关闭之
                Form form = this.ActiveMdiChild;
                form.Close();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
