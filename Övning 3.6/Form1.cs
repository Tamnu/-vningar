using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTeckensnitt_Click(object sender, EventArgs e)
        {
            
            DialogResult result = dlgFontdialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dlgFontdialog.Font;
            }
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = dlgcolor.ShowDialog();
            if(dr == DialogResult.OK)
            {
                richTextBox1.SelectionColor = dlgcolor.Color;
            }
        }
    }
}
