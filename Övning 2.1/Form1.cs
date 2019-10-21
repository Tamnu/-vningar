using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._1
{
    public partial class Form1 : Form
    {
        List<Media> medialist = new List<Media>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBok_Click(object sender, EventArgs e)
        {
            lbxVisa.Items.Clear();
            string title = tbxTitle.Text;
            int antalsidor = int.Parse(tbxSidor.Text);
            Bok nybok = new Bok(title, antalsidor);
            medialist.Add(nybok);
            lbxVisa.Items.Add(nybok);
            

        }
    }
}
