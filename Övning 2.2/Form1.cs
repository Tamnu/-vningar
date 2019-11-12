using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._2
{
    public partial class Form1 : Form
    {
        List<Anställd> banklist = new List<Anställd>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSäljare_Click(object sender, EventArgs e)
        {
            try
            {
                string namnSäljare = tbxNamnsell.Text;
                double provition = double.Parse(tbxProvision.Text);
                double försäljning = double.Parse(tbxFörsäljning.Text);

                Säljare säljare = new Säljare(namnSäljare, provition, försäljning);
                banklist.Add(säljare);
                lbxRegistrera.Items.Add(säljare);
                lbxLön.Items.Add(säljare + ":" + säljare.beräkna());
                
            }
            catch
            {
                MessageBox.Show("fel");
            }

        }

        private void BtnKonsult_Click(object sender, EventArgs e)
        {
            try
            {
                string namnKonsult = tbxNamnkonsult.Text;
                double Timlön = double.Parse(tbxTimlön.Text);
                double Arbetstid = double.Parse(tbxArbetattid.Text);
                Konsult konsult = new Konsult(namnKonsult, Arbetstid, Timlön);
                banklist.Add(konsult);
                lbxRegistrera.Items.Add(konsult);
                lbxLön.Items.Add(konsult + ":" + konsult.beräkna());
            }
            catch
            {
                MessageBox.Show("fel");
            }
        }

        private void BtnKontor_Click(object sender, EventArgs e)
        {
            try
            {
                string namnkontor = tbxNamnkontor.Text;
                double månadslön = double.Parse(tbxMånadslön.Text);
                Kontorist kontorist = new Kontorist(namnkontor, månadslön);
                banklist.Add(kontorist);
                lbxRegistrera.Items.Add(kontorist);
                lbxLön.Items.Add(kontorist);
                lbxLön.Items.Add(kontorist + ":" + kontorist.beräkna());
            }
            catch
            {
                MessageBox.Show("fel");
            }


        }

        private void BtnBeräkna_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach(Anställd a in banklist)
            {
                total = total + a.beräkna();
            }
            btnTotallön.Text = total.ToString();
        }
    }
}
