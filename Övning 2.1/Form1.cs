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
            try
            {
                string title = tbxTitle.Text;
                int antalsidor = int.Parse(tbxSidor.Text);
                Bok nybok = new Bok(title, antalsidor);
                medialist.Add(nybok);
                lbxVisa.Items.Add(nybok);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felkod 3e3e kontakta systemadministratören");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLjud_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbxTitleljud.Text;
                int speltid = int.Parse(tbxTidljud.Text);
                Ljudspår nyttljudspår = new Ljudspår(title, speltid);
                medialist.Add(nyttljudspår);
                lbxVisa.Items.Add(nyttljudspår);
            }
            catch
            {
                MessageBox.Show("Kontrollera inmatningen");
            }
            
        }

        private void BtnFilm_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbxTitlefilm.Text;
                int speltid = int.Parse(tbxTidfilm.Text);
                string upplösning = tbxUpplös.Text;
                Film nyfilm = new Film(title, speltid, upplösning);
                medialist.Add(nyfilm);
                lbxVisa.Items.Add(nyfilm);
            }
            catch
            {
                MessageBox.Show("Inmatningsfel");
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Media m = lbxVisa.SelectedItem as Media;
            //Media m2 = (Media)lbxVisa.SelectedItem;
            //medialist.Remove(m);
            //uppdateraListboxen
           
            if (m is Film)
            {
                Film f = m as Film;
                MessageBox.Show("Upplösningnen är: " + f.upplösning);
            }
            if(m is Bok)
            {
                Bok b = m as Bok;
                MessageBox.Show("antalsidor är: " + b.antalsidor);
            }
            if(m is Ljudspår)
            {
                Ljudspår l = m as Ljudspår;
                //MessageBox.Show()
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Media m = lbxVisa.SelectedItem as Media;
            medialist.Remove(m);
            lbxVisa.Items.Clear();
            foreach(Media s in medialist)
            {
                lbxVisa.Items.Add(s);
            }
        }
    }
}
