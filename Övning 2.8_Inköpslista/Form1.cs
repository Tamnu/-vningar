using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._8_Inköpslista
{
    public partial class Form1 : Form
    {
        List<Vara> korg = new List<Vara>();
        double summa = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLäggtill_Click(object sender, EventArgs e)
        {
            try
            {
                string vara = tbxVara.Text;
                double pris = double.Parse(tbxPris.Text);
                double mängd = int.Parse(tbxMängd.Text);

                if (RbtnLös.Checked == true)
                {
                    LösVikt lösvikt = new LösVikt(vara, pris, mängd);
                    korg.Add(lösvikt);
                    lbxVisa.Items.Add(lösvikt + "" + lösvikt.BeräknaPris() + "kr");
                }
                if (RbtnStycksak.Checked == true)
                {
                    StyckSak stycksak = new StyckSak(vara, pris, mängd);
                    korg.Add(stycksak);
                    lbxVisa.Items.Add(stycksak+ "" + stycksak.BeräknaPris() + "kr");
                }
                
                foreach(Vara s in korg)
                {
                    summa = summa + s.BeräknaPris();
                }
                tbxSumma.Text = summa.ToString();
            }
            catch
            {

            }

        }
    }
}
