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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLäggtill_Click(object sender, EventArgs e)
        {
            try
            {
                double summa = 0;
                string vara = tbxVara.Text;
                double pris = double.Parse(tbxPris.Text);
                double mängd = int.Parse(tbxMängd.Text);

                if (RbtnLös.Checked == true)
                {
                    LösVikt lösvikt = new LösVikt(vara, pris, mängd);
                    korg.Add(lösvikt);
                    lbxVisa.Items.Add(lösvikt);
                }
                if (RbtnStycksak.Checked == true)
                {
                    StyckSak stycksak = new StyckSak(vara, pris, mängd);
                    korg.Add(stycksak);
                    lbxVisa.Items.Add(stycksak);
                }
                
                foreach(Vara s in korg)
                {
                    summa = summa + s.BeräknaPris();
                }
                tbxSumma.Text = summa.ToString();
            }
            catch
            {
                MessageBox.Show("Fel inmatning");
            }

        }

        private void Btnremove_Click(object sender, EventArgs e)
        {
            Vara m = lbxVisa.SelectedItem as Vara;
            korg.Remove(m); 
            lbxVisa.Items.Clear();
            foreach(Vara s in korg)
            {
                lbxVisa.Items.Add(s + "" + s.BeräknaPris() + "Kr");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
