﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文档程序设计
{
    public partial class frmTxt : Form
    {
        public frmTxt()
        {
            InitializeComponent();
        }

        private void 文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 撤销UToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 撤销UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 删除LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText="";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int m = textBox1.SelectionStart;
            int Ln = 0;
            int Col = 0;
            for (int i = m - 1; i >= 0; i--)
            {
                if (str[i] == '\n')
                {
                    Ln++;
                }
                if (Ln < 1)
                {
                    Col++;
                }
            }
            Ln = Ln + 1;
            Col = Col + 1;
            toolStripStatusLabel1.Text = "行:" + Ln.ToString() + "," + "列:" + Col.ToString();
        }
    }
}
