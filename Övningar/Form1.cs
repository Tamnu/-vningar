using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övningar
{
    public partial class Form1 : Form
    {
        List<Fordon> fordonslista = new List<Fordon>();
        string[] regnr = new string[100];
        int räkna = 0;
        

        public Form1()
        {
            InitializeComponent();
            rdbAlla.Checked = true;
            
            
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string ord = "";
            string ord2 = "";
            lbxVisa.Items.Clear();
            string modell = tbxModell.Text;
            string märke = tbxMärk.Text;
            string reg = tbxReg.Text;
            int regcheck = reg.Length;
            if(regcheck == 6)
            {
                for (int i = 0; i < 3; i++)
                {
                       ord = ord + reg[i];
                }
                for (int i = 3; i < 6; i++)
                {
                      ord2 = ord2 + reg[i];
                }
                
            }
            else
            {
                MessageBox.Show("Fel","reg är fel", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            int.Parse(ord2);




            reg = ord + ord2;


            regnr[räkna++] = reg;
            
            int selectedFordonstyp = cbxTyp.SelectedIndex;            

            Fordon fordon = new Fordon(reg, modell, märke, (Fordon.fordonstyp)selectedFordonstyp);

            fordonslista.Add(fordon);

            check();
          
            

        }

        void check()
        {
            if (rdbBilar.Checked == true)
            {

                foreach (Fordon s in fordonslista)
                {
                    if (s.Typ == Fordon.fordonstyp.Bil)
                    {
                        lbxVisa.Items.Add(s);
                    }
                }
            }
            if (rdbAlla.Checked == true)
            {
                lbxVisa.Items.Clear();

                foreach (Fordon s in fordonslista)
                {
                    lbxVisa.Items.Add(s);
                }
            }
            if (rdbMC.Checked == true)
            {

                foreach (Fordon s in fordonslista)
                {
                    if (s.Typ == Fordon.fordonstyp.MC)
                    {
                        lbxVisa.Items.Add(s);
                    }
                }
            }
            foreach (Fordon s in fordonslista)
            {
                for (int i = 0; i < räkna; i++)
                {
                    if (s.Reg == regnr[i])
                    {
                        MessageBox.Show("Fel", "reg är fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

        }

        private void CbxTyp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void RdbAlla_CheckedChanged(object sender, EventArgs e)
        {
            lbxVisa.Items.Clear();
            check();
        }

        private void RdbBilar_CheckedChanged(object sender, EventArgs e)
        {
            lbxVisa.Items.Clear();
            check();
        }

        private void RdbMC_CheckedChanged(object sender, EventArgs e)
        {
            lbxVisa.Items.Clear();
            check();
        }
    }
}
