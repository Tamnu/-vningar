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
        string ord;
        string ord2;
        string[] lista = new string[20];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
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
            int.Parse(ord2);
            
            
            if(rdbBilar.Checked = true)
            {

                foreach (Fordon s in fordonslista)
                {
                    if(fordon)
                }
            }

            reg = ord + ord2;
            
            int selectedFordonstyp = cbxTyp.SelectedIndex;            

            Fordon fordon = new Fordon(reg, modell, märke, (Fordon.fordonstyp)selectedFordonstyp);

           
                lbxVisa.Items.Add(fordon);
            if(rdbAlla.Checked = true)
            {
                lbxVisa.Items.Clear();

                foreach (Fordon s in fordonslista)
                {
                    lbxVisa.Items.Add(fordon);
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

        }
    }
}
