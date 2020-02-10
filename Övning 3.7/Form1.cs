using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._7
{
    public partial class Form1 : Form
    {
        private List<Matcher> matcher = new List<Matcher>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;

                if (e.ColumnIndex == 0)
                {
                    matcher[i].hemmalag = (string)dataGridView1.Rows[i].Cells[0].Value;
                }
                else if (e.ColumnIndex == 1)
                {
                    matcher[i].bortalag = (string)dataGridView1.Rows[i].Cells[1].Value;

                }
                else if (e.ColumnIndex == 2)
                {
                    matcher[i].målhemmalag = int.Parse((string)dataGridView1.Rows[i].Cells[2].Value);
                }
                else if (e.ColumnIndex == 3)
                {
                    matcher[i].målbortalag = int.Parse((string)dataGridView1.Rows[i].Cells[3].Value);
                }
            }
            catch {
                MessageBox.Show("Fel inmatning");

            }


        }

        private void DataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Matcher nymatch = new Matcher();
            matcher.Add(nymatch);
        }

        private void BtnMålrikast_Click(object sender, EventArgs e)
        {
            try
            {
                string hemmalag = "";
                string bortalag = "";
                int antalmål = 0;
                for (int i = 0; i < matcher.Count; i++)
                {
                    if (matcher[i].målhemmalag + matcher[i].målbortalag > antalmål)
                    {
                        hemmalag = matcher[i].hemmalag;
                        bortalag = matcher[i].bortalag;
                        antalmål = matcher[i].målhemmalag + matcher[i].målbortalag;
                        
                    }
                    tbxMålrikast.Text = hemmalag + "  " + bortalag + ": " + antalmål;
                }
            }
            catch
            {
                MessageBox.Show("Fel inmatning");

            } 
        }

        private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Matcher match = e.Row.Tag as Matcher;
            matcher.Remove(match);

        }

        private void BtnSkjutned_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow rad = dataGridView1.SelectedRows[0];
                int index = rad.Index;
                if (index == dataGridView1.Rows.Count - 2) return;
                dataGridView1.Rows.RemoveAt(index);
                dataGridView1.Rows.Insert(index + 1, rad);
                rad.Selected = true;
            }
        }
    }
}
