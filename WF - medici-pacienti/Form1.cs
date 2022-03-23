using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF___medici_pacienti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Medic m1 = new Medic("Ionescu", DateTime.Now, "6010102265325", 2010, "Cardiologie");
            Medic m2 = new Medic("Florescu", DateTime.Now, "18101056542365", 2000, "Neurologie");

            ListViewItem lv = new ListViewItem(m1.NumePrenume);
            lv.SubItems.Add(m1.Cnp);
            lv.SubItems.Add(m1.Specializare);
            lv.Tag = m1;
            listView1.Items.Add(lv);

            lv = new ListViewItem(new string[] { m2.NumePrenume, m2.Cnp, m2.Specializare });
            lv.Tag = m2;
            listView1.Items.Add(lv);

            Pacient p1 = new Pacient("Pacient 1", new DateTime(1980, 12, 10), "1801210987786", "12345", "Inginer");
            Pacient p2 = new Pacient("Pacient 2", new DateTime(1975, 4, 5), "1750405435675", "789", "Economist");

            lv = new ListViewItem(new string[] { p1.NumePrenume, p1.Cnp, p1.CardSanatate });
            lv.Tag = p1;
            listView2.Items.Add(lv);

            lv = new ListViewItem(new string[] { p2.NumePrenume, p2.Cnp, p2.CardSanatate });
            lv.Tag = p2;
            listView2.Items.Add(lv);

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medic mForm1=null;
            FormMedic fm = new FormMedic(mForm1);
            fm.ShowDialog();
            if (fm.DialogResult == DialogResult.OK)
            {
                mForm1 = fm.mFormMedic;
                ListViewItem lv = new ListViewItem();
                lv = new ListViewItem(new string[] 
                { mForm1.NumePrenume, mForm1.Cnp, mForm1.Specializare });
                lv.Tag = mForm1;
                listView1.Items.Add(lv);
            }
        }

    }
}
