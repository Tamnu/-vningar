using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if(r == DialogResult.OK)
            {
                this.button1.BackColor = dlgColor.Color;
            }
                
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFolder.ShowDialog();

            if (r == DialogResult.OK)
            {
                this.button2.Text = dlgFolder.SelectedPath;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFont.ShowDialog();

            if(r == DialogResult.OK)
            {
                this.button3.Font = dlgFont.Font;
            }
        }

        private void VäljFärgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if (r == DialogResult.OK)
            {
                this.button1.BackColor = dlgColor.Color;
            }
        }

        private void VäljMappToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFolder.ShowDialog();

            if (r == DialogResult.OK)
            {
                this.button2.Text = dlgFolder.SelectedPath;
            }
        }

        private void VäljTeckensnittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFont.ShowDialog();

            if (r == DialogResult.OK)
            {
                this.button3.Font = dlgFont.Font;
            }
        }

        private void AaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
