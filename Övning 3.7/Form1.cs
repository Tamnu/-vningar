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
            dataGridView1.Rows.Add("HEj", "något", 1232131);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            
            if(e.ColumnIndex == 0)
            {
                matcher[i].hemmalag = (string)dataGridView1.Rows[i].Cells[0].Value;
            }
            else if(e.ColumnIndex == 1){
                matcher[i].bortalag = (string)dataGridView1.Rows[i].Cells[1].Value;

            }
            else if(e.ColumnIndex == 2)
            {
                matcher[i].målhemmalag
            }


        }

        private void DataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Matcher nymatch = new Matcher();
            matcher.Add(nymatch);
        }
    }
}
