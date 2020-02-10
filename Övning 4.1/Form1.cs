using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultat = dlgÖppna.ShowDialog();

            if(resultat == DialogResult.OK)
            {
                FileStream instöm = new FileStream(dlgÖppna.FileName, FileMode.Open, FileAccess.Read);
                StreamReader läsare = new StreamReader(instöm);
                string filtext = läsare.ReadToEnd();
                tbxDokument.Text = filtext;
                läsare.Dispose();
            }
        }
    }
}
