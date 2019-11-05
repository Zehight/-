using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notpad
{
    public partial class FrmChild : Form
    {
        public FrmChild()
        {
            InitializeComponent();
        }

        private void Parent_Load(object sender, EventArgs e)
        {
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            textBoxNote.Text = "";
            //清空窗体标题
            this.Text = "";
            //清空是否保存标记
            toolStripLabelMake.Text = "";

        }

        private void ToolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //设置文件类型过滤器
            ofd.Filter = "文本文档(*.txt)|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //保存文件到用户目录
                string inName = ofd.FileName;
                //将当前文件路径添加到标题位置
                this.Text = inName;
                StreamReader sr = new StreamReader(inName, Encoding.UTF8);//设置为通用的UTF8格式
                //读取到文件的最后一行
                textBoxNote.Text = sr.ReadToEnd();
                //关闭文件
                sr.Close();
                //清空保存标记
                toolStripLabelMake.Text = "";
            }
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            //点击保存时，把是否保存标记为空
            toolStripLabelMake.Text = "";
            //首先判断是否有文本内容
            if (textBoxNote.Text.Trim() != "")
            {
                //判断窗体标题是否为空，默认为空
                if (this.Text == "")
                {
                    //创建保存对话框对象
                    SaveFileDialog sfd = new SaveFileDialog();
                    //定义保存文件类型过滤器
                    sfd.Filter = "文本文件(*.txt)|*.txt";
                    //获取用户点击的按钮
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //保存文件到用户目录
                        string outName = sfd.FileName;
                        //创建写数据流对象
                        StreamWriter sw = new StreamWriter(outName, false);
                        //将数据写入到文件中
                        sw.WriteLine(textBoxNote.Text.Trim());
                        //刷新流
                        sw.Flush();
                        //关闭文件
                        sw.Close();
                        //将窗体标题设置为保存的路径名称
                        this.Text = outName;

                    }
                }
                else
                {
                    StreamWriter sw = new StreamWriter(this.Text, false);
                    sw.WriteLine(textBoxNote.Text.Trim());
                    sw.Flush();
                    sw.Close();
                }

            }
            else
            {
                MessageBox.Show("内容为空，不能保存", "信息提示");
            }
        }

        private void ToolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Font.Bold == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Bold);//加粗
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);//普通文本
            }
        }
        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            toolStripLabelMake.Text = "*";
        }
        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxSize.Text;
            textBoxNote.Font = new Font(fontName, float.Parse(toolStripComboBoxSize.Text));
        }

        private void toolStripComboBoxSize_TextChanged(object sender, EventArgs e)
        {

            string fontName = toolStripComboBoxSize.Text;
            if (fontName == "")
            {
                fontName = "10";
            }
            else
            {
                textBoxNote.Font = new Font(fontName, float.Parse(toolStripComboBoxSize.Text));
            }

        }
        private void FrmChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断记号是否为*
            if (toolStripLabelMake.Text == "*")
            {
                DialogResult re = MessageBox.Show("文档尚未保存，确定要退出吗", "友情提示", MessageBoxButtons.YesNo);
                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
