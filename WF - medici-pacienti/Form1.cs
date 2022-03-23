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

            TreeNode t = new TreeNode(m1.NumePrenume + " " + m1.Specializare);            
            t.Tag = m1;
            treeView1.Nodes.Add(t);
            t.Nodes.Add(new TreeNode(p1.NumePrenume + " " + p1.Cnp));
            t.Nodes.Add(new TreeNode(p2.NumePrenume + " " + p2.Cnp));

            t = new TreeNode(m2.NumePrenume + " " + m2.Specializare);
            t.Tag = m2;
            treeView1.Nodes.Add(t);

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

        private void buttonEditeazaMedic_Click(object sender, EventArgs e)
        {
            Medic mForm1=(Medic)listView1.SelectedItems[0].Tag;
            
            FormMedic fm = new FormMedic(mForm1);
            fm.ShowDialog();

            if (fm.DialogResult == DialogResult.OK)
            {
                ListViewItem lv = listView1.SelectedItems[0];
                lv.Text = mForm1.NumePrenume;
                lv.SubItems[1].Text = mForm1.Cnp;
                lv.SubItems[2].Text = mForm1.Specializare;

            }
        }

        private void toolStripMenuItemAdaugaMedic_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripMenuItemModificaMedic_Click(object sender, EventArgs e)
        {
            buttonEditeazaMedic_Click(sender, e);
        }

        private void toolStripMenuItemStergeMedic_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                toolStripMenuItemModificaMedic.Enabled = true;
                toolStripMenuItemStergeMedic.Enabled = true;
            }
            else
            {
                toolStripMenuItemModificaMedic.Enabled = false;
                toolStripMenuItemStergeMedic.Enabled = false;
            }
        }
    }
}
